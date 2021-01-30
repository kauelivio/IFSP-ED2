using System;
using System.Collections.Generic;
using System.Linq;

namespace Atividade_15_12
{
    class Livro
    {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;

        public Livro()
        {
            Isbn = 0;
            Titulo = "";
            Autor = "";
            Editora = "";
            Exemplares = new List<Exemplar>();
        }

        public int Isbn { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
        public List<Exemplar> Exemplares { get => exemplares; set => exemplares = value; }

        public void adicionarExemplar(Exemplar exemplar)
        {

            Exemplares.Add(exemplar);
        }

        public int qtdeExemplares()
        {
            return Exemplares.Count;
        }

        public int qtdeDisponiveis()
        {
            int qtd = 0;
            Emprestimo emp = new Emprestimo();
            foreach (Exemplar e in exemplares)
            {
                emp = e.Emprestimos.Last();
                if ((emp.DtEmprestimo == DateTime.MinValue && emp.DtDevolucao == DateTime.MinValue) || (emp.DtEmprestimo != DateTime.MinValue && emp.DtDevolucao != DateTime.MinValue))
                {
                    qtd++;
                }
            }
            return qtd;
        }

        public int qtdeEmprestimos()
        {
            int qtd = 0;
            Emprestimo emp = new Emprestimo();
            foreach (Exemplar e in exemplares)
            {
                emp = e.Emprestimos.Last();
                if (emp.DtEmprestimo != DateTime.MinValue && emp.DtDevolucao == DateTime.MinValue)
                {
                    qtd++;
                }
            }
            return qtd;
        }

        public double percDisponibilidade()
        {
            int qtd = 0;
            double por = 100.0;
            Emprestimo emp = new Emprestimo();
            foreach (Exemplar e in exemplares)
            {
                emp = e.Emprestimos.Last();
                if ((emp.DtEmprestimo == DateTime.MinValue && emp.DtDevolucao == DateTime.MinValue) || (emp.DtEmprestimo != DateTime.MinValue && emp.DtDevolucao != DateTime.MinValue))
                {
                    qtd++;
                }
            }
            if (qtd != 0)
            {
                por = (qtd / Exemplares.Count) * 100;
            }

            return por;
        }
    }
}
