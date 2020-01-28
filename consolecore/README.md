# Introdução com um projeto console ConsoleCore

## Comando utilizados
* dotnet new -h
* dotnet new console -n GameTop
* dotnet new classlib -n GameTop.Lib
* dotnet new sln -n GameTop para criar solution
* dotnet add .\GameTop\GameTop.csproj reference .\GameTop.Lib\GameTop.Lib.csproj para adicionar referencia
* dotnet sln .\GameTop.sln add .\GameTop\GameTop.csproj .\GameTop.Lib\GameTop.Lib.csproj para adicionar na solution
* dotnet watch run, observa a alteração dos arquivos e executa automaticamente o projeto no terminal