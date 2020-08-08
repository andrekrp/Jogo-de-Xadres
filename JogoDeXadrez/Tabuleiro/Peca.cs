﻿

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao pocicao { get; set; }
        public Cor cor { get; protected set; }

        public int qteMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca( Tabuleiro tab, Cor cor)
        {

            this.pocicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
                
        }

        public void implementarQteMovimentos()
        {
            qteMovimentos++;

        }

        public abstract bool[,] movimentosPossiveis();
        

    }
}
