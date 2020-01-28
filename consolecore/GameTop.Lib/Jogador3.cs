using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "O jogador 3 está Chutando";
        }

        public string Corre()
        {
            return "O jogador 3 está Correndo";
        }

        public string Passe()
        {
            return "O jogador 3 está Passando";
        }
    }
}