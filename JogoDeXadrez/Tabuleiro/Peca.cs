﻿

namespace tabuleiro
{
    class Peca
    {
        public Posicao pocicao { get; set; }
        public Cor cor { get; protected set; }

        public int qteMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {

            this.pocicao = pocicao;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        
        
        }

    }
}
