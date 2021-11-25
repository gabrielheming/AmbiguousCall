# AmbiguousCall

Repository created to demonstrate the [issue #175](https://github.com/ardalis/Specification/issues/175)

All the commands have been done using `dotnet cli`.

Version used to test: 

 * Latest version of .NET Core at this moment: 3.1.21 (SDK 3.1.415): link to download: https://dotnet.microsoft.com/download/dotnet/3.1
 * Latest version of .NET Core >= 5.0.12 (SDK 5.0.403): link to download: https://dotnet.microsoft.com/download/dotnet/5.0
 
 # How to proceed
 
 After cloning the repository, run the following commands using `dotnet cli`:
 
 ```
 $ dotnet restore
 $ dotnet build
 ```
 
 Error present running as .NET Core version `3.1.21`
 
 >AmbigousCall.cs(18,38): e Error CS0121: The call is ambiguous between the following methods or properties: "IReadRepositoryBase.ListAsync(CancellationToken)" and "IReadRepositoryBase.ListAsync(CancellationToken)" [D:\Projetos\repos\Study\ambiguous-call\Application\Application.csproj]
 
 The build runs properly when running as .NET Core version `5.0.12`.
 
 # Notes
 
 - This error doesn't happen when running the build through Visual Studio Community 2019;
 - This error happens when running on CI/CD environment (Tested on Azure Pipelines);
