using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atividade_15_12
{
    class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public Exemplar()
        {
            Tombo = 0;
            Emprestimos = new List<Emprestimo>();
        }

        public Exemplar(int t)
        {
            Tombo = t;
            Emprestimos = new List<Emprestimo>();
            Emprestimos.Add(new Emprestimo());
        }

        public int Tombo { get => tombo; set => tombo = value; }
        public List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }

        public bool emprestar()
        {
            bool veri = false;
            foreach (Emprestimo e in emprestimos)
            {
                if (e.DtEmprestimo == DateTime.MinValue && veri == false)
                {
                    e.DtEmprestimo = DateTime.Now;
                    veri = true;
                }
            }
            return veri;
        }

        public bool devolver()
        {
            bool veri = false;
            foreach (Emprestimo e in emprestimos)
            {
                if (e.DtEmprestimo != DateTime.MinValue && e.DtDevolucao == DateTime.MinValue && veri == false)
                {
                    e.DtDevolucao = DateTime.Now;
                    veri = true;
                }
            }

            if (veri == true)
            {
                emprestimos.Add(new Emprestimo());
            }
            return veri;
        }

        public bool disponivel()
        {
            bool veri = false;
            foreach (Emprestimo e in emprestimos)
            {
                if ((e.DtEmprestimo == DateTime.MinValue && e.DtDevolucao == DateTime.MinValue) || (e.DtEmprestimo != DateTime.MinValue && e.DtDevolucao != DateTime.MinValue))
                {
                    veri = true;
                }

            }
            return veri;
        }

        public int qtdeEmprestimos()
        {
            return Emprestimos.Count();
        }
    }
}
