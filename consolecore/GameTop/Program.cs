using System;
using GameTop.Lib;

namespace GameTop
{
    //dotnet new console -n GameTop
    //dotnet new classlib -n GameTop.Lib
    //dotnet new sln -n GameTop para criar solution
    //dotnet add .\GameTop\GameTop.csproj reference .\GameTop.Lib\GameTop.Lib.csproj para adicionar referencia
    //dotnet sln .\GameTop.sln add .\GameTop\GameTop.csproj .\GameTop.Lib\GameTop.Lib.csproj para adicionar na solution
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFera(
                new Jogador2(),
                new Jogador1("Jogador 1")
            );

            jogo.IniciarJogo();
        }
    }
}


