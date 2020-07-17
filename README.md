# POC:Proof Of Concept
Feed-products: POC

#SQL Solution

https://raw.githubusercontent.com/kunalverma94/POC/master/database/POCanswer.sql


# Prerequisites

![alt text](https://raw.githubusercontent.com/kunalverma94/POC/master/coding/img.jpg)

Syntax
>  poc <SITE> <PRODUCT_CATALOG>
            <SITE> := INVALID,Capterra,SoftwareAdvice
            <PRODUCT_CATALOG> :=Valid file Location
            Incase Of Absolute Path please provire with " <Path To file > "

•	.Net Core 3.1 Setup and Installation : Please Make sure .net Core  is installed on system , used the link below for .net core environment as per the O.S
     
     o	Linux: Follow instructions here   https://docs.microsoft.com/en-us/dotnet/core/install/linux
     o	Windows : https://dotnet.microsoft.com/download


# Installation 
 
 • Build the solution. 
 
 • \bin\Debug\netcoreapp3.1\
 
 • Add path to executable to system variable 

#Hot To Run
 
 -Demo
 -![Run](https://raw.githubusercontent.com/kunalverma94/POC/master/coding/img2.jpg)
 
 -video:https://raw.githubusercontent.com/kunalverma94/POC/master/coding/Demo.mp4
 
#Proof of Concept:

The application developed in .net Core 3.1.

For Maintainability and Scalability following design  patterns SOLID principals have been added as Of current Implementation

1.	Factory Pattern

2.	Builder Pattern

3.	Adapter Pattern

4.	Repository Like Pattern

5.	Dependency Injection (IOC)

Further Development May involve:

1.	Distributed of DTO ,modules into NuGet or standard DLL .

2.	More level of abstract or modularity could be implemented .

3.	Adding Comments and Summary Tags for more readability.

4.	Automation 

5.	CLI commands enrichment

6.	Providing more flags like

a.	–source : Web, local, sql, network



Features:

•	NO strong Dependency: 

o	Interface backs all the models.

o	Makes unit and Module testability easy.

o	Implementation guidelines

o	The comments could be added only in the interface and are reflected by inherit doc supplying more readability .

•	Abstraction:


o	The products are modeled into an instance Of IProduct .

o	An Adapter pattern ensures for providing all IProducts with same level of business maturity.

•	IOC : Dependency Injection

o	Supplies Lean and clean way of initialization and injection of instances.

•	MOQ :

o	Testing and Mocking done using MOQ library for testability

•	Modularity:

o	3  level

	Service Layer

	Data Layer

	Reader Layer (lower level  dealing with files, networks and stuff)

•	Tries to Support  “O” For open close

o	Provided as much implementation and separation  for addition of new provide, source, and products service.

•	All the basic appsetting and const variables provided in Appsetting static class To avoided and encourage placing all const fields ,to avoid bugs and redundancy.


#

Please contact for futher suggestions and improvement :

Kunal Verma

8329586462

kunalverma94@yahoo.com

Visit :http://kunalverma94.github.io/



