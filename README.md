# Dotnet Stdin Stdout Starter App

This app was created with the following.

```bash
mkdir dotnet-stdin-stdout
dotnet new sln -o .
dotnet new classlib -o DotnetStdinStdout
dotnet sln add DotnetStdinStdout/DotnetStdinStdout.csproj
dotnet new xunit -o DotnetStdinStdout.Tests
dotnet sln add ./DotnetStdinStdout.Tests/DotnetStdinStdout.Tests.csproj
 ```