using System;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; } //uma cor só pode ser usada por ela mesma e pelas subclasses(protected)
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; set; }
         
        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            this.QteMovimentos = 0;
        }               
    }
}
