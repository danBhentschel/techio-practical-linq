#!/usr/bin/perl

use strict;
use warnings;
no warnings "experimental::smartmatch";
use File::Find;
use File::Path qw(make_path remove_tree);

if (scalar(@ARGV) < 1) {
    print "\nUsage: sanitize_exercise.pl <project_dir>\n\n";
    exit;
}

sub sanitize_file($);

my $project_dir = $ARGV[0];
my $new_project_dir = "${project_dir}_sanitized";

remove_tree($new_project_dir);

my @skip_dirs = ( '.vs', 'obj', 'bin' );

sub wanted {
    if (-d) {
        if ($_ ~~ @skip_dirs) {
            $File::Find::prune = 1;
            return;
        }
        my $dest_dir = $File::Find::name;
        $dest_dir =~ s/\/$project_dir/\/$new_project_dir/;
        make_path($dest_dir);
    }

    elsif (-f) {
        sanitize_file($_);
    }
}

sub sanitize_file($) {
    my $filename = shift;

    print "$filename\n";
}

find(\&wanted, $project_dir);
