using System;
using System.Collections.Generic;
using System.Text;

namespace tp_final
{
    class EquipamentoS
    {
        private List<TipoEquip> estoque;

        public EquipamentoS()
        {
            estoque = new List<TipoEquip>();
        }

        public List<TipoEquip> Estoque { get => estoque; set => estoque = value; }

        public void incluir(TipoEquip tipE)
        {
            tipE.Id = estoque.Count + 1;
            estoque.Add(tipE);
        }

        public TipoEquip buscar(string nome)
        {
            TipoEquip ret = new TipoEquip();
            foreach (TipoEquip te in estoque)
            {
                if (te.Nome == nome)
                    ret = te;
            }
            return ret;
        }
    }
}
