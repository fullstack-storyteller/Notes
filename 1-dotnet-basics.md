# Basics of .net

Check out the below image to understand how the code execution differed in pre-.net era and post .net era

![comparison between pre-post .net code execution](/images/prepostdotnet.jpg)

### Main difference between a .net assembly and pre.net assembly (.dll or .exe)

| Pre .net Assembly                       | .Net Assembly                                                                                            |
| --------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| Contains native code (Machine Code)     | Contains intermediate language (MSIL)                                                                    |
| This will be directly run by the OS     | This is will require a Common Language Runtime (CLR) to execute/ convert the MSIL to Native/Machine code |
| No CLR                                  | CLR and .Net framework class Library (FCL) will installed when installing .net framework on the machine  |
| This is not portable                    | This is highly portable if corresponding .net FCL and CLR are installed in the machine                   |
| High level code-> machine language-> OS | High level code-> CLR(IL -> Just-In-Time compiler-> machine code)-> OS                                   |
