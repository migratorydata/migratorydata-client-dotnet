@echo off

rem !!! Please define the correct path of your C# compiler (csc.exe) !!!
set PATH_CSHARP_COMPILER=c:\windows\microsoft.net\framework\v2.0.50727\
set Path=%PATH_CSHARP_COMPILER%;%PATH%

csc.exe /target:exe /reference:migratorydata-client-dotnet.dll sample-client.cs

