#!/usr/bin/perl

use strict;
use warnings;

sub get_markdown_files_from($);
sub embed_in_file($$);
sub print_line($);
sub get_embeded_content($$);

if (scalar(@ARGV) < 1) {
    print "\nUsage: embed_examples.pl <yml_file>\n\n";
    exit;
}

my $yml_file = $ARGV[0];
my $markdowns = get_markdown_files_from($yml_file);

foreach my $file (@$markdowns) {
    my $template = $file;
    $template =~ s/\.md$/.template.md/;
    embed_in_file($template, $file);
}

sub get_markdown_files_from($) {
    my $filename = shift;

    open(my $fh, "<", $filename) or die "Can't open < $filename: $!";
    my @lines = <$fh>;
    close($fh);

    chomp @lines;
    my @statement_lines = grep /statement:\s*.*\.md/, @lines;
    my @files = map { s/\s*statement:\s*//r } @statement_lines;
    return \@files;
}

sub embed_in_file($$) {
    my $template = shift;
    my $out_file = shift;

    return unless -f $template;

    open(my $fh, "<", $template) or die "Can't open < $template: $!";
    my @lines = <$fh>;
    close($fh);

    open($fh, ">", $out_file) or die "Can't open < $out_file: $!";

    print $fh "[//]: # (GENERATED FILE -- DO NOT EDIT)\n";

    foreach my $line (@lines) {
        print $fh get_line($line);
    }

    close($fh);

    print "$out_file\n";
}

sub get_line($) {
    my $line = shift;

    if ($line =~ /\/\/\/\/\s*EMBED:\s*(.*?),\s*(.*)/) {
        return get_embedded_content($1, $2);
    } else {
        return $line;
    }
}

sub get_embedded_content($$) {
    my $filename = shift;
    my $content_tag = quotemeta shift;

    open(my $fh, "<", $filename)
        or die "Can't open < $filename $!";
    my @lines = <$fh>;
    close($fh);

    my $should_print = 0;
    my $start_spaces = "";
    my $in_elide = 0;
    my $result = "";
    my %replacements = ();
    foreach my $line (@lines) {
        if ($should_print) {
            if ($line =~ /\/\/\/\/\s*END EMBED\s*\/\/\/\//) {
                return $result;
            }

            if ($line =~ /\/\/\/\/\s*START ELIDE\s*\/\/\/\//) {
                $in_elide = 1;
                $result .= "  ...\n";
            }

            if ($line =~ /\/\/\/\/\s*START REPLACE:\s*"?(.*?)"?\s*:::\s*"?(.*?)"?\s*\/\/\/\//) {
                $replacements{"$1"} = $2;
                next;
            }

            if ($line =~ /\/\/\/\/\s*END REPLACE:\s*"?(.*?)"?\s*\/\/\/\// && defined $replacements{"$1"}) {
                delete $replacements{"$1"};
                next;
            }

            if ($in_elide) {
                if ($line =~ /\/\/\/\/\s*END ELIDE\s*\/\/\/\//) {
                    $in_elide = 0;
                }

                next;
            }

            foreach my $pattern (keys(%replacements)) {
                my $quoted = quotemeta $pattern;
                $line =~ s/$quoted/$replacements{"$pattern"}/g;
            }

            if ($start_spaces) {
                $line =~ s/^$start_spaces//;
            }

            $line =~ s/\r\n/\n/;

            $result .= $line;
        }
        elsif ($line =~ /(\s*)\/\/\/\/\s*START EMBED:\s*$content_tag\s*\/\/\/\//) {
            $should_print = 1;
            $start_spaces = $1;
        }
    }

    return "ERROR: CONTENT NOT FOUND FOR TAG \"$content_tag\" in $filename\n";
}
