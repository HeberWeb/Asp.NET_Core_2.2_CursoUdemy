# Seção 2: Asp.NET Core - API

## Alguns comandos que foram necessários.
* Instalar pelo Nuget Microsoft.EntityFrameworkCore.Sqlite
* dotnet tool install --global dotnet-ef --version 3.1.0, foi necessário instalar a versão 3.1.0 em relação ao Microsoft.NETCore.App com a mesma disponível
* Instalar  pelo Nuget Microsoft.EntityFrameworkCore.Design para migrations

## Comando ef
dotnet ef -h
dotnet ef migrations add "nome da migration"
dotnet ef database -h
dotnet ef database update