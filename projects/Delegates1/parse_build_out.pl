#!/usr/bin/perl

use warnings;
use strict;

my $filename = $ARGV[0];
open( my $fh, '<', $filename ) or die "Can't open $filename: $!";

my @lines = <$fh>;

foreach my $line (grep /^CG>/, @lines) { print $line; }

print "CG> message --channel \"exercise results\" \"\"\n";
print "CG> message --channel \"exercise results\" \"\"\n";
print "CG> message --channel \"exercise results\" \"\"\n";
print "CG> message --channel \"====================\" \"\"\n";

foreach my $line (grep $_ !~ /^CG>/, @lines) {
    chomp $line;
    if ($line =~ /^(.*\.cs)\((\d+),(\d+)\): error (CS\d+:.*)$/) {
        print "CG> annotate --file $1 --position $2:$3 --message \"$4\"\n";
    }
    print "CG> message --channel \"raw output\" $line\n";
}

close($fh);
