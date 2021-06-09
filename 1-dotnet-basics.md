# Basics of .net

Check out the below image to understand how the code execution differed in pre-.net era and post .net era

![comparison between pre-post .net code execution](/images/prepostdotnet.jpg)

### Main difference between a .net assembly and pre.net assembly (.dll or .exe)

| Pre .Net Assembly                            | .Net Assembly                                                                                            |
| -------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| Contains native code (Machine Code)          | Contains intermediate language (MSIL)                                                                    |
| This assembly will be directly run by the OS | This is will require a Common Language Runtime (CLR) to execute/ convert the MSIL to Native/Machine code |
| No CLR                                       | CLR and .Net framework class Library (FCL) will installed when installing .net framework on the machine  |
| This is not portable                         | This is highly portable if corresponding .net FCL and CLR are installed in the machine                   |
| High level code-> machine language-> OS      | High level code-> CLR(IL -> Just-In-Time compiler-> machine code)-> OS                                   |

#### Just-In-Time Compiler

JIT Compiler takes the MSIL and converts it into corresponding machine code.

#### Common Language Runtime

It provides a lot of things(to be added here later)

1. Garbage Collection: .Net Assemblies don't have to handle freeing up memories or cleanup of unreferenced object as CLR's garbage collecter does it for them.
