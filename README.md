# Core-EditorConfig
.editorcfg file with c# coding styles for visual studio

## What is EditorConfig?
To quote directly from [editorconfig.org](http://editorconfig.org):

> *EditorConfig is a file format and collection of text editor plugins for maintaining consistent coding styles between different editors and IDEs.*

The file format is basically a simple text file format that allows developers to specify:
* one or more (glob) patterns that match source code files (e.g. "[*.cs]") 
* a collection of attributes that define coding styles for the matched source code files (e.g. "indent_style = space")
* cascading of multiple .editorcfg files, for overwriting coding styles on a folder level

Those files can be checked in along with the source code and therefore be easily shared by developers across the team.

## What does this repository contain?
This repository contains a single .editorcfg file that defines the code styles and naming conventions I personally prefer when developing c# applications. The file can be used as a template or directly be added at the solution level to enforce coding styles for the entiry solution.

In addition to that there is a small c# (.netstandard 1.6) project that acts as a showcase/playground and can be used to play around with the single .editorcfg settings. The examples used in this project are mainly shamelessly copied from [Kent Boogaarts](https://kent-boogaart.com/blog/editorconfig-reference-for-c-developers) excellent blog post or directly from [Microsoft](https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-code-style-settings-reference).

## References
* [EditorConfig.Org](http://editorconfig.org)
* [EditorConfig Reference for C# Developers](https://kent-boogaart.com/blog/editorconfig-reference-for-c-developers)
* [DocsMicrosoft.Com](https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-code-style-settings-reference)
* [Working with EditorConfig in Visual Studio 2017](https://almvm.azurewebsites.net/labs/tfs/editorconfig/)
