using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_12_01
{
    class Usuario
    {
        private int id;
        private string nome;
        private List<Ambiente> ambientes;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }

        public bool concederPermissao(Ambiente ambiente)
        {
            bool suc = true;
            foreach (Ambiente a in ambientes)
            {
                if (a.Nome == ambiente.Nome)
                {
                    suc = false;
                }
            }
            if (suc == true)
            {
                ambientes.Add(ambiente);
            }
            return suc;
        }

        public bool revogarPermissao(Ambiente ambiente)
        {
            bool suc = false;
            foreach (Ambiente a in ambientes)
            {
                if (a.Nome == ambiente.Nome)
                {
                    ambientes.Remove(a);
                    suc = true;
                }
            }

            return suc;
        }
    }
}
