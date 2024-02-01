using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
<<<<<<< HEAD
            return "T";
=======
            return "T ";
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
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

            // verificando acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
<<<<<<< HEAD
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
=======
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            // abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            // direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            // esquerda
<<<<<<< HEAD
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
=======
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }

            return mat;
        }
    }
}