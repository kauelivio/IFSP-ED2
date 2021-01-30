using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_05_01
{
    class Lote
    {
        private int id;
        private int qtde;
        private DateTime venc;

        public Lote(int id, int qtde, DateTime venc)
        {
            this.Id = id;
            this.Qtde = qtde;
            this.Venc = venc;
        }

        public Lote()
        {
            this.Id = 0;
            this.Qtde = 0;
            this.Venc = DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public DateTime Venc { get => venc; set => venc = value; }

        public string toString()
        {
            return id + " - " + qtde + " - " + venc;
        }
    }
}
