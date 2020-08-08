using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;

        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima

            pos.definirValores(pocicao.linha - 1, pocicao.coluna);
            
           if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //nordeste

            pos.definirValores(pocicao.linha - 1, pocicao.coluna +1 );

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //direita

            pos.definirValores(pocicao.linha , pocicao.coluna + 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //sudeste

            pos.definirValores(pocicao.linha + 1, pocicao.coluna + 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //abaixo

            pos.definirValores(pocicao.linha + 1, pocicao.coluna );

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //sudueste

            pos.definirValores(pocicao.linha - 1, pocicao.coluna - 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //esquerda

            pos.definirValores(pocicao.linha , pocicao.coluna - 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //noroeste

            pos.definirValores(pocicao.linha - 1, pocicao.coluna - 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
    }
}
