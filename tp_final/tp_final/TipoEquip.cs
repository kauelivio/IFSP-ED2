using System;
using System.Collections.Generic;
using System.Text;

namespace tp_final
{
    class TipoEquip
    {
        private int id;
        private string nome;
        private List<Equipamento> itens;

        public TipoEquip()
        {
            id = 0;
            nome = "";
            itens = new List<Equipamento>();
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public List<Equipamento> Itens { get => itens; set => itens = value; }

        public void incluir(Equipamento eqp)
        {
            eqp.Id = itens.Count + 1;
            itens.Add(eqp);
        }

        public Equipamento buscar(int id)
        {
            Equipamento ret = new Equipamento();
            foreach (Equipamento e in itens)
            {
                if (e.Id == id)
                    ret = e;
            }
            return ret;
        }

        public override bool Equals(object obj)
        {
            return (this.nome.Equals(((TipoEquip)obj).nome));
        }
    }
}
