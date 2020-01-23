using System;

namespace GameTop
{
    //dotnet new console -n GameTop
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


