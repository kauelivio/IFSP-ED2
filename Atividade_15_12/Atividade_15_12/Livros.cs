using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_15_12
{
    class Livros
    {
        private List<Livro> acervo;

        public Livros()
        {
            Acervo = new List<Livro>();
        }

        public List<Livro> Acervo { get => acervo; set => acervo = value; }

        public void adicionar(Livro livro)
        {
            Acervo.Add(livro);
        }

        public Livro pesquisar(Livro livro)
        {
            Livro retorno = new Livro();

            foreach (Livro l in acervo)
            {
                if (l.Isbn == livro.Isbn)
                {
                    retorno = l;
                }
            }

            return retorno;
        }
    }
}
