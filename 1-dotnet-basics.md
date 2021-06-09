# Basics of .NET

Check out the below image to understand how the code execution differed in pre-.net era and post .net era

![comparison between pre-post .net code execution](/images/prepostdotnet.jpg)

## Main difference between a .net assembly and pre.net assembly (.dll or .exe)

| Pre .Net Assembly                            | .Net Assembly                                                                                                                            |
| -------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| Contains native code (Machine Code)          | Contains intermediate language (MSIL)                                                                                                    |
| This assembly will be directly run by the OS | This is will require a Common Language Runtime (CLR) to execute/ convert the MSIL to Native/Machine code                                 |
| No CLR                                       | CLR and .Net framework class Library (FCL) will installed when installing .net framework on the machine                                  |
| This is not portable                         | This is highly portable if corresponding .net FCL and CLR are installed in the machine, i.e. conversion to platform specific native code |
| High level code-> machine language-> OS      | High level code-> CLR(IL -> Just-In-Time compiler-> machine code)-> OS                                                                   |
| Example: VB6, C++                            | Example: C#, VB, J# and also C++ (for backwards compatibility)                                                                           |
| It is fast from get go                       | First time it will be slow as IL has to be made but further execution of the IL will be fast                                             |

## Intermeditate language (More to be added)

1. It is also called Managed code as it is managed by the CLR, where as Native code in pre .net era was called unmanaged code
2. Intermediate Language is also known as Microsoft Intermediated language(MSIL) or Common Intermediate Language(CIL)

## Just-In-Time Compiler (More to be added)

JIT Compiler takes the MSIL and converts it into corresponding machine code.

## Common Language Runtime (More to be added)

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

## Strong naming an assembly

In .Net, assemblies can be broadly classified into 2 types

1. Weak named assemblies
2. Strong named assemblies

An assembliy name consists of 4 parts

1. Simple textual name
2. Version Number
3. Culture information (otherwise the assembly is language neutral, also when you specify the culture attribute it becomes a _*satelite assemebly*_. Its usually empty)
4. Public key token

We use Assemblyversion attribute to specifiy the Assembly version. The default is `1.0.0.0`. The version number f an assembly consists of the following parts:

1. Major Version
2. Minor Version
3. Build Number
4. Revision Number

### Strong Naming an Assembly

We can strongly name an assembly to deploy them in GAC. For ensuring multiple version of assemblies to exist together. _Remember that only a strongly named assembly can be placed in GAC_. This primarily helps in solving the DLL-Hell Problem (we will see more on that later)

### How to make a strong named Assembly

1. Open the visual studio command prompt as Administrator
2. run the code `sn.exe -k c:/mynewstrongnamekeyfile.snk`
3. it will generate a `mynewstrongnamekeyfile.snk` file to be used in our AssemblyInfo.cs file as `[assembly: AssemblyKeyFile("C:\\mynewstrongnamekeyfile.snk")]`
4. Rebuild the application, and the newly generated assembly will be an strongly named assembly

### Global Assembly Cache (GAC)

A location which ets us store **_strongly named assemblies_** ( including multiple versions of the same assemblies) for their use in multiple applications. This assembly will not be moved or copies locally for individual applications as every applicationi can reference them from the GAC location.

#### How to install an assembly in GAC

1. Make the assembly a strong named assembly
2. Open Visual Studion Command Prompt as administrator
3. Reach the location of the assembly directory
4. For installing an assembly into GAC run the command: `gacutil.exe -i assembly-name.extension`
   > Note different target .Net Framework will have different GAC location
   > See below...
5. For uninstalling an assembly use: `gacutil.exe -u assembly-name`

   > Remember this, to delete all versions of an assembly from the GAC, simply specifiy the Assembly Name

   > To delete a specific version of an assenmbly from the GAC, you must give the command as: `gacutil.exe -u assembly-name,Version=version-number-no-quotes,PublicKeyToken=public-key-token-no-quotes`. No spaces!!!

#### Global Assembly Cache (GAC) locations

- Pre .NET 4 location: `C:\Windows\assembly`
- Post .NET 4 location: `C:\Windows\Microsoft.NET\assembly`

## How .NET finds the assemblies during program execution

1. **.Net figures out what version is needed:** Usually the information about the dependant assemblies is present in the application's assembly manifests. CLR checks the application configuration file, publisher policy file(if exists), and machine config file for information that overrides the version information stored in the calling assemblies manisfest.

2. **.Net searches GAC:** .Net searches GAC only if the assembly is strongly named.

3. **if the assembly is not found in the GAC**, and if there is a .config file, then .Net searches the location in the configuration file, else .Net searches the directory containing the executable (.exe)

4. **If the assembly is not found**, the application terminates with error.

**Note:** **_ Version checking is not done for Weakly Named Assemblies_**
