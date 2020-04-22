------------------------------------------------------
.NET Core CLI --> Commands to create the solution 
------------------------------------------------------
dotnet new sln -o unit-testing-using-dotnet-test
cd unit-testing-using-dotnet-test
dotnet new classlib -o PrimeService
ren .\PrimeService\Class1.cs PrimeService.cs
dotnet sln add ./PrimeService/PrimeService.csproj
dotnet new xunit -o PrimeService.Tests
dotnet add ./PrimeService.Tests/PrimeService.Tests.csproj reference ./PrimeService/PrimeService.csproj
dotnet sln add ./PrimeService.Tests/PrimeService.Tests.csproj
dotnet add package Moq 
--------------------------------------------------------------------
MSTest
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
[TestMethod]
--------------------------------------------------------------------
NUnit Test
using NUnit.Framework;
[TestFixture]
[SetUp]
[Test]
---------------------------------------------------------------------
xUnit Test
using Xunit;
[Fact]
---------------------------------------------------------------------
xUnit is pretty lean compared to NUnit and MsTest and has been written more recently. The .NET framework has evolved since NUnit was first created. 
XUnit leverage some of the new features to help developers write cleaner test, as tests should be kept clean and treated as first-class citizens.

Some of the reasons why we went with xUnit:

NUnit was not fully compatible with .NET Core 2 at the time
We wanted to move away from MS Test, as the team preferred the xUnit and NUnit way of writing tests
xUnit is aimed at improving test isolation and trying to codify a set of rules to establish a testing standard.
xUnit [Fact] and [Theory] attributes are extensible, so you can implement your own testing functionality.xUnit doesn’t use Test Lists and .vsmdi files to keep track of your tests.
Microsoft is using xUnit internally, one of its creators is from Microsoft. xUnit was also created by one of the original authors of NUnit.
There are no [Setup] and [Teardown] attributes, this is done using the test class’ constructor and an IDisposable. This encourages developers to write cleaner tests.
xUnit allows us to write less code since its flexibility allows things like subspec which allow you to write only what you need to do. Using tools such as xBehave: http://xbehave.github.io/ and Xunit.Gherkin.Quick.
xUnit is easier to read and uses intuitive terminology.

--------------------------------------------------------------




