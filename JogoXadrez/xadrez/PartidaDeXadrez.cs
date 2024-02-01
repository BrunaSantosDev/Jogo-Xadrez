using System.Collections.Generic;
using tabuleiro;
using System.Collections.Generic;

namespace xadrez
{
    class PartidaDeXadrez
    {
<<<<<<< HEAD

        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada { get; private set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;
        public bool xeque { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            xeque = false;
=======
        public Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;
        public bool Xeque { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            Xeque = false;
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
            colocarPecas();
        }

        public Peca executaMovimento(Posicao origem, Posicao destino)
        {
<<<<<<< HEAD
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
=======
            Peca p = Tab.retirarPeca(origem);
            p.incrementarQteMovimetos();
            Peca pecaCapturada = Tab.retirarPeca(destino);
            Tab.colocarPeca(p, destino);
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
            if (pecaCapturada != null)
            {
                capturadas.Add(pecaCapturada);
            }
<<<<<<< HEAD

            // #jogadaespecial roque pequeno
            if (p is Rei && destino.coluna == origem.coluna + 2)
            {
                Posicao origemT = new Posicao(origem.linha, origem.coluna + 3);
                Posicao destinoT = new Posicao(origem.linha, origem.coluna + 1);
                Peca T = tab.retirarPeca(origemT);
                T.incrementarQteMovimentos();
                tab.colocarPeca(T, destinoT);
            }

            // #jogadaespecial roque grande
            if (p is Rei && destino.coluna == origem.coluna - 2)
            {
                Posicao origemT = new Posicao(origem.linha, origem.coluna - 4);
                Posicao destinoT = new Posicao(origem.linha, origem.coluna - 1);
                Peca T = tab.retirarPeca(origemT);
                T.incrementarQteMovimentos();
                tab.colocarPeca(T, destinoT);
            }

=======
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
            return pecaCapturada;
        }

        public void desfazMovimento(Posicao origem, Posicao destino, Peca pecaCapturada)
        {
<<<<<<< HEAD
            Peca p = tab.retirarPeca(destino);
            p.decrementarQteMovimentos();
            if (pecaCapturada != null)
            {
                tab.colocarPeca(pecaCapturada, destino);
                capturadas.Remove(pecaCapturada);
            }
            tab.colocarPeca(p, origem);

            // #jogadaespecial roque pequeno
            if (p is Rei && destino.coluna == origem.coluna + 2)
            {
                Posicao origemT = new Posicao(origem.linha, origem.coluna + 3);
                Posicao destinoT = new Posicao(origem.linha, origem.coluna + 1);
                Peca T = tab.retirarPeca(destinoT);
                T.decrementarQteMovimentos();
                tab.colocarPeca(T, origemT);
            }

            // #jogadaespecial roque grande
            if (p is Rei && destino.coluna == origem.coluna - 2)
            {
                Posicao origemT = new Posicao(origem.linha, origem.coluna - 4);
                Posicao destinoT = new Posicao(origem.linha, origem.coluna - 1);
                Peca T = tab.retirarPeca(destinoT);
                T.decrementarQteMovimentos();
                tab.colocarPeca(T, origemT);
            }
=======
            Peca p = Tab.retirarPeca(destino);
            p.decrementarQteMovimetos();
            if (pecaCapturada != null)
            {
                Tab.colocarPeca(pecaCapturada, destino);
                capturadas.Remove(pecaCapturada);
            }
            Tab.colocarPeca(p, origem);
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            Peca pecaCapturada = executaMovimento(origem, destino);

<<<<<<< HEAD
            if (estaEmXeque(jogadorAtual))
=======
            if (estaEmXeque(JogadorAtual))
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
            {
                desfazMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você não pode se colocar em xeque!");
            }
<<<<<<< HEAD

            if (estaEmXeque(adversaria(jogadorAtual)))
            {
                xeque = true;
            }
            else
            {
                xeque = false;
            }

            if (testeXequemate(adversaria(jogadorAtual)))
            {
                terminada = true;
            }
            else
            {
                turno++;
=======
            if (estaEmXeque(adversaria(JogadorAtual)))
            {
                Xeque = true;
            }
            else
            {
                Xeque = false;
            }
            if (testeXequeMate(adversaria(JogadorAtual)))
            {
                Terminada = true;
            }
            else
            {
                Turno++;
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
                mudaJogador();
            }
        }

        public void validarPosicaoDeOrigem(Posicao pos)
        {
<<<<<<< HEAD
            if (tab.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            }
            if (jogadorAtual != tab.peca(pos).cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis())
=======
            if (Tab.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida");
            }
            if (JogadorAtual != Tab.peca(pos).Cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!Tab.peca(pos).existeMovimentosPossiveis())
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
            {
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida!");
            }
        }

        public void validarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
<<<<<<< HEAD
            if (!tab.peca(origem).movimentoPossivel(destino))
=======
            if (!Tab.peca(origem).movimentoPossivel(destino))
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
            {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }

        private void mudaJogador()
        {
<<<<<<< HEAD
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Amarela;
            }
            else
            {
                jogadorAtual = Cor.Branca;
=======
            if (JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Amarela;
            }
            else
            {
                JogadorAtual = Cor.Branca;
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
            }
        }

        public HashSet<Peca> pecasCapturadas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in capturadas)
            {
<<<<<<< HEAD
                if (x.cor == cor)
=======
                if (x.Cor == cor)
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Peca> pecasEmJogo(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in pecas)
            {
<<<<<<< HEAD
                if (x.cor == cor)
=======
                if (x.Cor == cor)
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(pecasCapturadas(cor));
            return aux;
        }

        private Cor adversaria(Cor cor)
        {
            if (cor == Cor.Branca)
            {
                return Cor.Amarela;
            }
            else
            {
                return Cor.Branca;
            }
        }

        private Peca rei(Cor cor)
        {
            foreach (Peca x in pecasEmJogo(cor))
            {
                if (x is Rei)
                {
                    return x;
                }
            }
            return null;
        }

        public bool estaEmXeque(Cor cor)
        {
            Peca R = rei(cor);
            if (R == null)
            {
                throw new TabuleiroException("Não tem rei da cor " + cor + " no tabuleiro!");
            }
<<<<<<< HEAD
            foreach (Peca x in pecasEmJogo(adversaria(cor)))
            {
                bool[,] mat = x.movimentosPossiveis();
                if (mat[R.posicao.linha, R.posicao.coluna])
=======

            foreach (Peca x in pecasEmJogo(adversaria(cor)))
            {
                bool[,] mat = x.movimentosPossiveis();
                if (mat[R.Posicao.Linha, R.Posicao.Coluna])
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
                {
                    return true;
                }
            }
            return false;
        }

<<<<<<< HEAD
        public bool testeXequemate(Cor cor)
=======
        public bool testeXequeMate(Cor cor)
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
        {
            if (!estaEmXeque(cor))
            {
                return false;
            }
            foreach (Peca x in pecasEmJogo(cor))
            {
                bool[,] mat = x.movimentosPossiveis();
<<<<<<< HEAD
                for (int i = 0; i < tab.linhas; i++)
                {
                    for (int j = 0; j < tab.colunas; j++)
                    {
                        if (mat[i, j])
                        {
                            Posicao origem = x.posicao;
=======
                for (int i = 0; i < Tab.Linhas; i++)
                {
                    for (int j = 0; j < Tab.Colunas; j++)
                    {
                        if (mat[i, j])
                        {
                            Posicao origem = x.Posicao;
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
                            Posicao destino = new Posicao(i, j);
                            Peca pecaCapturada = executaMovimento(origem, destino);
                            bool testeXeque = estaEmXeque(cor);
                            desfazMovimento(origem, destino, pecaCapturada);
                            if (!testeXeque)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public void colocarNovaPeca(char coluna, int linha, Peca peca)
        {
<<<<<<< HEAD
            tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
=======
            Tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
            pecas.Add(peca);
        }

        private void colocarPecas()
        {
<<<<<<< HEAD
            colocarNovaPeca('a', 1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('b', 1, new Cavalo(tab, Cor.Branca));
            colocarNovaPeca('c', 1, new Bispo(tab, Cor.Branca));
            colocarNovaPeca('d', 1, new Dama(tab, Cor.Branca));
            colocarNovaPeca('e', 1, new Rei(tab, Cor.Branca, this));
            colocarNovaPeca('f', 1, new Bispo(tab, Cor.Branca));
            colocarNovaPeca('g', 1, new Cavalo(tab, Cor.Branca));
            colocarNovaPeca('h', 1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('a', 2, new Peao(tab, Cor.Branca));
            colocarNovaPeca('b', 2, new Peao(tab, Cor.Branca));
            colocarNovaPeca('c', 2, new Peao(tab, Cor.Branca));
            colocarNovaPeca('d', 2, new Peao(tab, Cor.Branca));
            colocarNovaPeca('e', 2, new Peao(tab, Cor.Branca));
            colocarNovaPeca('f', 2, new Peao(tab, Cor.Branca));
            colocarNovaPeca('g', 2, new Peao(tab, Cor.Branca));
            colocarNovaPeca('h', 2, new Peao(tab, Cor.Branca));

            colocarNovaPeca('a', 8, new Torre(tab, Cor.Amarela));
            colocarNovaPeca('b', 8, new Cavalo(tab, Cor.Amarela));
            colocarNovaPeca('c', 8, new Bispo(tab, Cor.Amarela));
            colocarNovaPeca('d', 8, new Dama(tab, Cor.Amarela));
            colocarNovaPeca('e', 8, new Rei(tab, Cor.Amarela, this));
            colocarNovaPeca('f', 8, new Bispo(tab, Cor.Amarela));
            colocarNovaPeca('g', 8, new Cavalo(tab, Cor.Amarela));
            colocarNovaPeca('h', 8, new Torre(tab, Cor.Amarela));
            colocarNovaPeca('a', 7, new Peao(tab, Cor.Amarela));
            colocarNovaPeca('b', 7, new Peao(tab, Cor.Amarela));
            colocarNovaPeca('c', 7, new Peao(tab, Cor.Amarela));
            colocarNovaPeca('d', 7, new Peao(tab, Cor.Amarela));
            colocarNovaPeca('e', 7, new Peao(tab, Cor.Amarela));
            colocarNovaPeca('f', 7, new Peao(tab, Cor.Amarela));
            colocarNovaPeca('g', 7, new Peao(tab, Cor.Amarela));
            colocarNovaPeca('h', 7, new Peao(tab, Cor.Amarela));
=======
            // Peças brancas
            colocarNovaPeca('a', 1, new Torre(Tab, Cor.Branca));
            colocarNovaPeca('b', 1, new Cavalo(Tab, Cor.Branca));
            colocarNovaPeca('c', 1, new Bispo(Tab, Cor.Branca));
            colocarNovaPeca('d', 1, new Dama(Tab, Cor.Branca));
            colocarNovaPeca('e', 1, new Rei(Tab, Cor.Branca));
            colocarNovaPeca('f', 1, new Bispo(Tab, Cor.Branca));
            colocarNovaPeca('g', 1, new Cavalo(Tab, Cor.Branca));
            colocarNovaPeca('h', 1, new Torre(Tab, Cor.Branca));
            // Peoes brancos
            colocarNovaPeca('a', 2, new Peao(Tab, Cor.Branca));
            colocarNovaPeca('b', 2, new Peao(Tab, Cor.Branca));
            colocarNovaPeca('c', 2, new Peao(Tab, Cor.Branca));
            colocarNovaPeca('d', 2, new Peao(Tab, Cor.Branca));
            colocarNovaPeca('e', 2, new Peao(Tab, Cor.Branca));
            colocarNovaPeca('f', 2, new Peao(Tab, Cor.Branca));
            colocarNovaPeca('g', 2, new Peao(Tab, Cor.Branca));
            colocarNovaPeca('h', 2, new Peao(Tab, Cor.Branca));

            // Peças amarelas
            colocarNovaPeca('a', 8, new Torre(Tab, Cor.Amarela));
            colocarNovaPeca('b', 8, new Cavalo(Tab, Cor.Amarela));
            colocarNovaPeca('c', 8, new Bispo(Tab, Cor.Amarela));
            colocarNovaPeca('d', 8, new Rei(Tab, Cor.Amarela));
            colocarNovaPeca('e', 8, new Dama(Tab, Cor.Amarela));
            colocarNovaPeca('f', 8, new Bispo(Tab, Cor.Amarela));
            colocarNovaPeca('g', 8, new Cavalo(Tab, Cor.Amarela));
            colocarNovaPeca('h', 8, new Torre(Tab, Cor.Amarela));
            // Peoes amarelos
            colocarNovaPeca('a', 7, new Peao(Tab, Cor.Amarela));
            colocarNovaPeca('b', 7, new Peao(Tab, Cor.Amarela));
            colocarNovaPeca('c', 7, new Peao(Tab, Cor.Amarela));
            colocarNovaPeca('d', 7, new Peao(Tab, Cor.Amarela));
            colocarNovaPeca('e', 7, new Peao(Tab, Cor.Amarela));
            colocarNovaPeca('f', 7, new Peao(Tab, Cor.Amarela));
            colocarNovaPeca('g', 7, new Peao(Tab, Cor.Amarela));
            colocarNovaPeca('h', 7, new Peao(Tab, Cor.Amarela));
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
        }
    }
}