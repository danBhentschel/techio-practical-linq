#!/usr/bin/perl

use strict;
use warnings;
no warnings "experimental::smartmatch";
use File::Find;
use File::Path qw(make_path remove_tree);
use File::Basename;
use File::Copy;

if (scalar(@ARGV) < 1) {
    print "\nUsage: sanitize_exercise.pl <project_dir>\n\n";
    exit;
}

sub sanitize_file($$);

my $project_dir = $ARGV[0];
$project_dir =~ s/\/$//;
my $new_project_dir = "${project_dir}_sanitized";

remove_tree($new_project_dir);

my @skip_dirs = ( '.vs', 'obj', 'bin' );

sub wanted {
    if (-d) {
        my $dest_dir = $File::Find::name;
        if (fileparse($dest_dir) ~~ @skip_dirs) {
            $File::Find::prune = 1;
            return;
        }
        $dest_dir =~ s/(\/|^)$project_dir/$1$new_project_dir/;
        make_path($dest_dir);
    }
    elsif (-f) {
        my $dest_filename = $File::Find::name;
        $dest_filename =~ s/(\/|^)$project_dir/$1$new_project_dir/;
        sanitize_file($File::Find::name, $dest_filename);
    }
}

sub sanitize_file($$) {
    my $filename = shift;
    my $dest_filename = shift;

    copy($filename, "${dest_filename}.orig");

    open(my $fh, "<", $filename) or die "Can't open < $filename: $!";
    my @lines = <$fh>;
    close($fh);

    open($fh, ">", $dest_filename) or die "Can't open < $dest_filename $!";

    my $should_print = 1;
    foreach my $line (@lines) {
        if ($should_print) {
            if ($line =~ /\/\/\/\/\s*START SOLUTION\s*\/\/\/\//) {
                $should_print = 0;
                next;
            }
            print $fh $line;
        }
        elsif ($line =~ /\/\/\/\/\s*END SOLUTION\s*\/\/\/\//) {
            $should_print = 1;
        }
    }

    close($fh);

    #open(STDERR, "> /dev/null");
    my $dirname = dirname($dest_filename);
    my $success = system('dos2unix', $dest_filename);
    while ($success != 0) {
        my $tmpfile = glob "$dirname/d2utmp*";
        $success = !rename($tmpfile, $dest_filename);
    }
    $success = system('dos2unix', "${dest_filename}.orig");
    while ($success != 0) {
        my $tmpfile = glob "$dirname/d2utmp*";
        $success = !rename($tmpfile, "${dest_filename}.orig");
    }
}

$File::Find::dont_use_nlink = 1;
find({ wanted => \&wanted, no_chdir => 1 }, $project_dir);
