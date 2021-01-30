using System;
using System.Collections.Generic;
using System.Text;

namespace tp_final
{
    class LocacaoS
    {
        private List<Locacao> contratos;

        public LocacaoS()
        {
            contratos = new List<Locacao>();
        }

        public List<Locacao> Contratos { get => contratos; set => contratos = value; }

        public void incluir(Locacao aloc)
        {
            aloc.Id = contratos.Count + 1;
            contratos.Add(aloc);
        }
    }
}
