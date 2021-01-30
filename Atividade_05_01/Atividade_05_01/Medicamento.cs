using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_05_01
{
    class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes = new Queue<Lote>();
 
        public Medicamento()
        {
            this.Id = 0;
            this.Nome = "";
            this.Laboratorio = "";
        }

        public Medicamento(int id, string nome, string laboratorio, Queue<Lote> lotes)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
            lotes = new Queue<Lote>();
        }

        public Medicamento(int id, string nome, string laboratorio)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }
        public Queue<Lote> Lotes { get => lotes; set => lotes = value; }
        public int V1 { get; }
        public string V2 { get; }
        public string V3 { get; }

        public int qtdeDisponivel()
        {
            int total = 0;
            foreach (Lote l in lotes)
            {
                total += l.Qtde;
            }
            return total;
        }

        public void comprar(Lote lote)
        {
            lotes.Enqueue(lote);
        }

        public Boolean vender(int qtde)
        {

            if (qtde > qtdeDisponivel())
            {
                return false;
            }
            else
            {
                int qtdeFaltando = qtde;
                int qtdeLotes = lotes.Count;
                for (int i = 0; i <= qtdeLotes; i++)
                {
                    if (qtdeFaltando > lotes.Peek().Qtde)
                    {
                        qtdeFaltando -= lotes.Peek().Qtde;
                        lotes.Peek().Qtde = 0;
                        lotes.Dequeue();

                    }
                    else
                    {
                        lotes.Peek().Qtde -= qtdeFaltando;
                        qtdeFaltando = 0;
                        break;
                    }
                }
                return true;
            }

        }

        public string toString()
        {
            return id + " - " + nome + " - " + laboratorio + " - " + qtdeDisponivel();
        }

        public Boolean Equals(Object obj)
        {
            if (this == obj)
            {
                return true;
            }
            else return false;
        }
    }
}
