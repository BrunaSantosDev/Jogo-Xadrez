<<<<<<< HEAD
﻿using tabuleiro;

namespace xadrez
{

    class Cavalo : Peca
    {

=======
﻿using System;
using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
<<<<<<< HEAD
            return "C";
=======
            return "C ";
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

            pos.definirValores(posicao.linha - 1, posicao.coluna - 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.definirValores(posicao.linha - 2, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.definirValores(posicao.linha - 2, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.definirValores(posicao.linha - 1, posicao.coluna + 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.definirValores(posicao.linha + 1, posicao.coluna + 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.definirValores(posicao.linha + 2, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.definirValores(posicao.linha + 2, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.definirValores(posicao.linha + 1, posicao.coluna - 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
=======
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 2);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha - 2, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha - 2, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 2);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 2);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha + 2, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha + 2, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 2);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
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
