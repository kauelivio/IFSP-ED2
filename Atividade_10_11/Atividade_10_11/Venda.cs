using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_10_11
{
    class Venda
    {
        private int qtde;
        private double valor;

        public Venda()
        {
            Qtde = 0;
            Valor = 0.0;
        }

        public Venda(int qtde, double valor)
        {
            this.Qtde = qtde;
            this.Valor = valor;
        }

        public int Qtde { get => qtde; set => qtde = value; }
        public double Valor { get => valor; set => valor = value; }

        public double valorMedio()
        {
            return valor / qtde;
        }
    }
}
