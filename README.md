# POC:Proof Of Concept
Feed-products: POC

Kunal Verma
8329586462
kunalverma94@yahoo.com
Visit :http://kunalverma94.github.io/


#Proof of Concept:
The application is made in .net Core 3.1.
For Maintainability and Scalability following design  patterns SOLID principals have been added:
1.	Factory Pattern
2.	Builder Pattern
3. Adapter Pattern
5.	Repository Like Pattern
6. Dependency INjection (IOC)
7. Further distributed of DTO ,modules into NuGet or standard DLL could be done ..Limited by Time.
though such a simple functionality could be implemented in  coople of lines ,

EG :(https://www.nuget.org/packages/ConsoleTimeOutReader/)

-But this initial investment provide long maintaiable  code.

-App is deveoped in such a way that provides proper absraction and singularity

-All the products are provided as an IProduct ineerface .An adapter class provides necessary mapping for all.
the enduser may experience all products as single type

-The Data Provider and Data I/O  modues are properly sepereated

-Proper patterns used to avoid and hard binding or dependency.

-The Code could have been further disperced and coaresed But that may have been too much 
considering the initial commit for app
 
 -Implemented IOC
 
 -employed MOQ for testing support

# Installation 

 #Please follow the video in the repo for installaion

 #video Instructions/Demo
 
 video:https://raw.githubusercontent.com/kunalverma94/POC/master/coding/Demo.mp4
 
 
# Please Make sure .net Core  is installed on system , used the link below for .net core environment as per the O.S


Windows

https://dotnet.microsoft.com/download


Linux

https://docs.microsoft.com/en-us/dotnet/core/install/linux

Please add the executable to the OS Environment  for CLI.

Please follow video for installation
![alt text](https://raw.githubusercontent.com/kunalverma94/POC/master/coding/img.jpg)


#




