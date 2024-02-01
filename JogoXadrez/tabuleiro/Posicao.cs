namespace tabuleiro
{
    class Posicao
    {

<<<<<<< HEAD
        public int linha { get; set; }
        public int coluna { get; set; }
=======
        public Posicao()
        {
        }
>>>>>>> 44d5cf8bf8c28534a77fb82a2919d386c2c8b16f

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}