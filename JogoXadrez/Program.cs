using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD

=======
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
<<<<<<< HEAD

                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

=======
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.Tab, posicoesPossiveis);

>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
<<<<<<< HEAD
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.imprimirPartida(partida);
=======
                        Console.WriteLine();
                        Console.WriteLine("Pressione enter para continuar...");
                        Console.ReadLine();
                    }                    
                }
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
<<<<<<< HEAD

            Console.ReadLine();
=======
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
                Console.WriteLine("Pressione enter para continuar...");
                Console.ReadLine();
            }
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f
        }
    }
}