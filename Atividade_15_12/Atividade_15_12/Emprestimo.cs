using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_15_12
{
    class Emprestimo
    {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;

        public Emprestimo()
        {
            DtEmprestimo = new DateTime();
            DtDevolucao = new DateTime();
        }

        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
        public DateTime DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }
    }
}
