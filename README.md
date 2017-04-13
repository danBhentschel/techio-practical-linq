# cg-linq-for-beginners
A lesson on C# LINQ, for CodinGame Learning platform

A description of the course can be found in the `about.md` file.

# pre-commit and post-commit
To enable:

```bash
cd .git/hooks
ln -s ../../pre-commit
ln -s ../../post-commit
```

## embed_examples.pl
This script is run from `pre-commit`. It parses template files and inserts code into them before committing to Git.

### Problems
 - Some code examples are repeated in more than one place in a course. I sometimes forget to edit all places the example exists.
 - When modifying code examples, I will sometimes inadvertently write code that doesn't compile.
 - I want to be able to unit test my code examples so I know for sure that they actually do what I say they do.

### Solution
The `embed_examples.pl` script parses the `codingame.yml` file and gets a list of all markdown files in the course. It then looks for
a `.template.md` file associated with each one. If the template file exists, it parses the file looking for lines that match the
following pattern:

```
//// EMBED: <file_path>, <tag>
```

The `file_path` is a path, from the root of the course, to a source code file that contains the example code. The `tag` is a descriptive
name for the code to pull from that file.

The source code file can contain the following lines in it:

```
//// START EMBED: <tag> ////
//// END EMBED ////
//// START REPLACE: "<pattern>" ::: "<replacement>" ////
//// END REPLACE: "<pattern>" ////
//// START ELIDE ////
//// END ELIDE ////
```

The `START EMBED` and `END EMBED` lines start and end the section of code defined by `tag`. The `START REPLACE` and `END REPLACE` lines
bracket an area in which all instances of `pattern` will be replaced with `replacement`. The `START ELLIDE` and `END ELIDE` lines
bracket an area within an embedded code section that will be ommitted, and replaced with ellipses (...).

### Example

In the markdown template:
```
//// EMBED: foo.sh, The first example
```

In `foo.sh`:
```bash
#!/bin/bash

# Just a stupid example
echo before embed
# //// START EMBED: The first example ////
echo foo
# //// START REPLACE: "echo" ::: "echo -n" ////
echo foo
# //// START ELIDE ////
echo in elide
# //// END REPLACE: "echo" ////
echo still in elide
# //// END ELIDE ////
echo bar
# //// END EMBED ////
echo after embed
```

Resultant embedded code:
```
echo foo
echo -n foo
  ...
echo bar
```
