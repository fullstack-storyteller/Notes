# Basics of .net

Check out the below image to understand how the code execution differed in pre-.net era and post .net era

![comparison between pre-post .net code execution](/images/prepostdotnet.jpg)

### Main difference between a .net assembly and pre.net assembly (.dll or .exe)

| Pre .Net Assembly                            | .Net Assembly                                                                                                                            |
| -------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| Contains native code (Machine Code)          | Contains intermediate language (MSIL)                                                                                                    |
| This assembly will be directly run by the OS | This is will require a Common Language Runtime (CLR) to execute/ convert the MSIL to Native/Machine code                                 |
| No CLR                                       | CLR and .Net framework class Library (FCL) will installed when installing .net framework on the machine                                  |
| This is not portable                         | This is highly portable if corresponding .net FCL and CLR are installed in the machine, i.e. conversion to platform specific native code |
| High level code-> machine language-> OS      | High level code-> CLR(IL -> Just-In-Time compiler-> machine code)-> OS                                                                   |
| Example: VB6, C++                            | Example: C#, VB, J# and also C++ (for backwards compatibility)                                                                           |
| It is fast from get go                       | First time it will be slow as IL has to be made but further execution of the IL will be fast                                             |

#### Intermeditate language (More to be added)

1. It is also called Managed code as it is managed by the CLR, where as Native code in pre .net era was called unmanaged code
2. Intermediate Language is also known as Microsoft Intermediated language(MSIL) or Common Intermediate Language(CIL)

#### Just-In-Time Compiler (More to be added)

JIT Compiler takes the MSIL and converts it into corresponding machine code.

#### Common Language Runtime (More to be added)

It provides a lot of things(to be added here later)

1. Garbage Collection: .Net Assemblies don't have to handle freeing up memories or cleanup of unreferenced object as CLR's garbage collecter does it for them.

## Assemblies

Any .net Application -> Compile -> Assembly (.exe or .dll)
Assembly contains - **_Manifest and IL_**

Some information in the assembly manifest can be mdified using attributes.

We use ILDASM.exe (Intermediate language Dissassembler) to peek at the assembly manifest and IL. You can laso use this tool to export manisfest (meta data about your assembly for example name of the assembly and its version and various other details about dependencies and their versions) an IL to a text file.

We use ILASM.exe (Intermediate language Assembler) tp reconstruct an assembly from a text file that contains manifest and IL.

### Using ILDASM tool

1. Open the visual studio command prompt as Administrator
2. run the command `ildasm.exe fully-qualified-name-of-the-assembly-(.dll or .exe)`
3. It will open the ILDASM dialog box with maifest and IL information
4. You can use File -> Dump -> select the location to save -> give a proper file name with .il extension if needed -> save

### Using ILASM tool

1. Open the visual studio command prompt as Administrator
2. run the command `ilasm.exe fully-qualified-name-of-the-.il file`
3. It will read the content of the .il file and reconstruct the assembly
