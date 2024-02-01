<<<<<<< HEAD
﻿using tabuleiro;

namespace xadrez
{

    class Bispo : Peca
    {

=======
﻿using System;
using tabuleiro;

namespace xadrez
{
    class Bispo : Peca
    {
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
<<<<<<< HEAD
            return "B";
=======
            return "B ";
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
        }

        private bool podeMover(Posicao pos)
        {
<<<<<<< HEAD
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
=======
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != Cor;
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
        }

        public override bool[,] movimentosPossiveis()
        {
<<<<<<< HEAD
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            // Verificando noroeste
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha - 1, pos.coluna - 1);
            }

            // nordeste
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha - 1, pos.coluna + 1);
            }

            // sudeste
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna + 1);
            }

            // sudoeste
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna - 1);
=======
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            // verificando noroeste
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            }
            // nordeste
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna + 1);
            }
            // sudeste
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna + 1);
            }
            // sudoeste
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna - 1);
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
            }

            return mat;
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
