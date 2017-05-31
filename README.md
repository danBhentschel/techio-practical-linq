# techio-practical-linq
A lesson on C# LINQ, for the tech.io learning platform

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
The `embed_examples.pl` script parses the `techio.yml` file and gets a list of all markdown files in the course. It then looks for
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

## remove_md_files.pl
This script is run from `post-commit`. It removes generated markdown files after committing to Git.

### Problem
I frequently found myself editing the generated files by accident, rather than the template files.

### Solution
Remove generated files after they have been committed.

## sanitize_projects.pl
This script is run from `pre-commit`. It parses project files and removes solution code from them before committing to Git.

### Problems
 - I want to be able to unit test my exercise code in a development environment.
 - I want to ensure that my exercises are solvable before pushing changes.
 - I want the ability to present non-compiling exercise stub code to the student.
 - I want the ability to include multiple exercises in a single project.
 - C# files written in Visual Studio tend to have a BOM at the beginning of the file, which the TECH.IO platform doesn't support for code stubs.
 
All this requires that the stub code presented to the student must be different from the code run in the development environment, and also different from the code run by the runner.

### Solution
The `sanitize_projects.pl` script parses the `techio.yml` file and gets a list of all projects in the course. It then copies all the files into a new directory: `<project_dir>_sanitized`. The files are content filtered during the copy process, as described below.

Any content found between the following lines will be removed during copy:
```
//// START SOLUTION ////
//// END SOLUTION ////
```

This allows the developer to insert solution code into the stub files that will be automatically removed later.

In addition, the files are run through `dos2unix` after the copy operation, and a copy of the original files is also made in the `<project_dir>_sanitized` directory. The `build` script in the docker runner will replace the sanitized files with these original files at project build time. See [danBhentschel/cg-dotnet-runner](https://github.com/danBhentschel/cg-dotnet-runner) for more info.
