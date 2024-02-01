<<<<<<< HEAD
﻿using tabuleiro;

namespace xadrez
{

    class Peao : Peca
    {

=======
﻿using System;
using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
<<<<<<< HEAD
            return "P";
=======
            return "P ";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != Cor;
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
        }

        private bool existeInimigo(Posicao pos)
        {
<<<<<<< HEAD
            Peca p = tab.peca(pos);
            return p != null && p.cor != cor;
        }

        private bool livre(Posicao pos)
        {
            return tab.peca(pos) == null;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            // Peoes Brancos
            if (cor == Cor.Branca)
            {
                pos.definirValores(posicao.linha - 1, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha - 2, posicao.coluna);
                Posicao p2 = new Posicao(posicao.linha - 1, posicao.coluna);
                if (tab.posicaoValida(p2) && livre(p2) && tab.posicaoValida(pos) && livre(pos) && qteMovimentos == 0)
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
            }

            // Peoes Amarelos
            else
            {
                pos.definirValores(posicao.linha + 1, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha + 2, posicao.coluna);
                Posicao p2 = new Posicao(posicao.linha + 1, posicao.coluna);
                if (tab.posicaoValida(p2) && livre(p2) && tab.posicaoValida(pos) && livre(pos) && qteMovimentos == 0)
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
=======
            Peca p = Tab.peca(pos);
            return p != null && p.Cor != Cor;
        }
        
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            // Peões Brancos
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                pos.definirValores(Posicao.Linha - 2, Posicao.Coluna);
                if (Tab.posicaoValida(pos) && podeMover(pos) && QteMovimentos == 0)
                {

                    mat[pos.Linha, pos.Coluna] = true;

                }
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }

            // Peões Pretos
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                pos.definirValores(Posicao.Linha + 2, Posicao.Coluna);
                if (Tab.posicaoValida(pos) && podeMover(pos) && QteMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;

                }
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
                }
            }

            return mat;
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
