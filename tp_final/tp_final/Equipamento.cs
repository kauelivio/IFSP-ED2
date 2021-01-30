using System;
using System.Collections.Generic;
using System.Text;

namespace tp_final
{
    class Equipamento
    {
        private int id;
        private bool avaria;
        private bool locado;

        public Equipamento()
        {
            id = 0;
            avaria = false;
            locado = false;
        }

        public int Id { get => id; set => id = value; }
        public bool Avaria { get => avaria; set => avaria = value; }
        public bool Locado { get => locado; set => locado = value; }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Equipamento)obj).id);
        }
    }
}
