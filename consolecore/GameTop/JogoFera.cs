using System;

namespace GameTop
{
    public class JogoFera
    {
        private readonly iJogador _JogadorA;
        private readonly iJogador _JogadorB;

        public JogoFera(iJogador jogadorA, iJogador jogadorB)
        {
            _JogadorA = jogadorA;
            _JogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            Console.WriteLine(_JogadorA.Corre());
            Console.WriteLine(_JogadorA.Chuta());
            Console.WriteLine(_JogadorA.Passe());

            Console.WriteLine("Próximo Jogador");

            Console.WriteLine(_JogadorB.Corre());
            Console.WriteLine(_JogadorB.Chuta());
            Console.WriteLine(_JogadorB.Passe());
        } 
    }
}