using System;
using System.Collections.Generic;
using System.Text;

namespace tp_final
{
    class Locacao
    {
        private int id;
        private bool liberado = false;
        private DateTime data_saida;
        private DateTime data_retorno;
        private Stack<TipoEquip> itens;

        public Locacao()
        {
            id = 0;
            liberado = false;
            data_saida = new DateTime();
            data_retorno = new DateTime();
            itens = new Stack<TipoEquip>();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool Liberado
        {
            get { return liberado; }
            set { liberado = value; }
        }

        public DateTime Data_saida
        {
            get { return data_saida; }
            set { data_saida = value; }
        }

        public DateTime Data_retorno
        {
            get { return data_retorno; }
            set { data_retorno = value; }
        }

        public Stack<TipoEquip> Itens
        {
            get { return itens; }
            set { itens = value; }
        }

        public void incluir(TipoEquip eTip)
        {
            eTip.Id = itens.Count + 1;
            itens.Push(eTip);
        }

        public TipoEquip buscar(string nome)
        {
            TipoEquip ret = new TipoEquip();
            foreach (TipoEquip te in itens)
            {
                if (te.Nome == nome)
                {
                    ret = te;
                }
            }
            return ret;
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Locacao)obj).id);
        }
    }
}
