# dotnet-stacktest-xunit

## description
this is another .net6 test project with xUnit

tests a developed custom stack

developed on Visual Studio Code

## commands
commands on Visual Studio Code to create this project

* dotnet new sln -o dotnet-stacktest-xunit
* cd dotnet-stacktest-xunit
* dotnet new classlib -o StackService.Library
* ren .\StackService.Library\Class1.cs CustomStack.cs
* dotnet new xunit -o StackService.Tests
* ren .\StackService.Tests\UnitTest1.cs CustomStackTest.cs
* dotnet add ./StackService.Tests/StackService.Tests.csproj reference ./* StackService.Library/StackService.Library.csproj

type commands on Visual Studio Code to run the test

* cd .\StackService.Tests\ 
* dotnet test   (manual test)
* dotnet watch test (auto test)



