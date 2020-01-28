using System;
using GameTop.Interface;

namespace GameTop
{
    public class JogoFera
    {
        private readonly iJogador _JogadorA;
        private readonly iJogador _JogadorB;
        private readonly iJogador _JogadorC;

        public JogoFera(iJogador jogadorA, iJogador jogadorB, iJogador jogadorC)
        {
            _JogadorA = jogadorA;
            _JogadorB = jogadorB;
            _JogadorC = jogadorC;
        }
        
        public void IniciarJogo()
        {
            Console.WriteLine(_JogadorA.Corre());
            Console.WriteLine(_JogadorA.Chuta());
            Console.WriteLine(_JogadorA.Passe());

            Console.WriteLine("Próximo Jogador 2");

            Console.WriteLine(_JogadorB.Corre());
            Console.WriteLine(_JogadorB.Chuta());
            Console.WriteLine(_JogadorB.Passe());

            
            Console.WriteLine("Agora o Jogador 3");

            Console.WriteLine(_JogadorC.Corre());
            Console.WriteLine(_JogadorC.Chuta());
            Console.WriteLine(_JogadorC.Passe());
        } 
    }
}