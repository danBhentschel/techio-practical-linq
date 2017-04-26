#!/usr/bin/perl

use strict;
use warnings;
no warnings "experimental::smartmatch";
use File::Find;
use File::Path qw(make_path remove_tree);
use File::Basename;
use File::Copy;

sub get_projects_from($);
sub sanitize_file($$);
sub process_project($);
sub unixify_file($);

my @skip_dirs = ( '.vs', 'obj', 'bin' );
$File::Find::dont_use_nlink = 1;

if (scalar(@ARGV) < 1) {
    print "\nUsage: sanitize_projects.pl <yml_file>\n\n";
    exit;
}

my $yml_file = $ARGV[0];
my $projects = get_projects_from($yml_file);

my @done;
foreach my $project_dir (@$projects) {
    process_project($project_dir);
}

print join(" ", @done);

sub get_projects_from($) {
    my $filename = shift;

    open(my $fh, "<", $filename) or die "Can't open < $filename: $!";
    my @lines = <$fh>;
    close($fh);

    chomp @lines;
    my @root_lines = grep /root:\s*.*_sanitized/, @lines;
    my @dirs = map { s/\s*root:\s*\/?(.*_sanitized)\/?/$1/r } @root_lines;
    return \@dirs;
}

sub process_project($) {
    my $sanitized_dir = shift;

    my $project_dir = $sanitized_dir;
    $project_dir =~ s/_sanitized//;
    remove_tree($sanitized_dir);

    my $wanted = sub {
        if (-d) {
            my $dest_dir = $File::Find::name;
            if (fileparse($dest_dir) ~~ @skip_dirs) {
                $File::Find::prune = 1;
                return;
            }
            $dest_dir =~ s/(\/|^)$project_dir/$1$sanitized_dir/;
            make_path($dest_dir);
        }
        elsif (-f) {
            my $dest_filename = $File::Find::name;
            $dest_filename =~ s/(\/|^)$project_dir/$1$sanitized_dir/;
            sanitize_file($File::Find::name, $dest_filename);
            unixify_file($dest_filename);
            push @done, "\"$dest_filename\"";

            my $orig_filename = "${dest_filename}.orig";
            copy($File::Find::name, $orig_filename);
            unixify_file($orig_filename);
            push @done, "\"$orig_filename\"";
        }
    };

    find({ wanted => $wanted, no_chdir => 1 }, $project_dir);
}

sub sanitize_file($$) {
    my $filename = shift;
    my $dest_filename = shift;

    open(my $fh, "<", $filename) or die "Can't open < $filename: $!";
    my @lines = <$fh>;
    close($fh);

    open($fh, ">", $dest_filename) or die "Can't open < $dest_filename $!";

    my $should_print = 1;
    my $should_uncomment = 0;
    foreach my $line (@lines) {
        if ($should_print) {
            if ($line =~ /\/\/\/\/\s*START SOLUTION\s*\/\/\/\//) {
                $should_print = 0;
                next;
            }
            if ($line =~ /\/\/\/\/\s*START UNCOMMENT\s*\/\/\/\//) {
                $should_uncomment = 1;
                next;
            }
            if ($line =~ /\/\/\/\/\s*END UNCOMMENT\s*\/\/\/\//) {
                $should_uncomment = 0;
                next;
            }
            if ($should_uncomment) {
                $line =~ s/^(\s*)#*\/*(\s*)/$1$2/;
            }
            print $fh $line;
        }
        elsif ($line =~ /\/\/\/\/\s*END SOLUTION\s*\/\/\/\//) {
            $should_print = 1;
        }
    }

    close($fh);
}

sub unixify_file($) {
    my $filename = shift;

    open(STDERR, "> /dev/null");
    my $dirname = dirname($filename);
    my $success = system('dos2unix', $filename);
    while ($success != 0) {
        my $tmpfile = glob "$dirname/d2utmp*";
        $success = !rename($tmpfile, $filename);
    }
}
