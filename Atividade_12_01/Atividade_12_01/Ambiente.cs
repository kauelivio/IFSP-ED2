using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_12_01
{
    class Ambiente
    {
        private int id;
        private string nome;
        private Queue<Log> logs;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Queue<Log> Logs
        {
            get { return logs; }
            set { logs = value; }
        }

        public void registrarLog(Log log)
        {
            logs.Enqueue(log);
        }
    }
}
