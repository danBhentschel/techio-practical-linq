#!/usr/bin/perl

use strict;
use warnings;

sub get_markdown_files_from($);

if (scalar(@ARGV) < 1) {
    print "\nUsage: embed_examples.pl <yml_file>\n\n";
    exit;
}

my $yml_file = $ARGV[0];
my $markdowns = get_markdown_files_from($yml_file);

foreach my $file (@$markdowns) {
    my $template = $file;
    $template =~ s/\.md$/.template.md/;
    if (-f $template) {
        print "Removing generated file: $file\n";
        unlink($file);
    }
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
