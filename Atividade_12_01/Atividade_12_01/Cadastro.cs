using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_12_01
{
    class Cadastro
    {
        private List<Usuario> usuarios;
        private List<Ambiente> ambientes;

        public List<Usuario> Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }

        public List<Ambiente> Ambientes
        {
            get { return ambientes; }
            set { ambientes = value; }
        }

        public Cadastro()
        {
            usuarios = new List<Usuario>();
            ambientes = new List<Ambiente>();
        }


        public void adicionarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public bool removerUsuario(Usuario usuario)
        {
            bool suc = false;
            foreach (Usuario u in usuarios)
            {
                if (u.Nome == usuario.Nome)
                {
                    usuarios.Remove(u);
                }
            }
            return suc;
        }

        public Usuario pesquisarUsuario(Usuario usuario)
        {
            Usuario retorno = new Usuario();
            foreach (Usuario u in usuarios)
            {
                if (u.Nome == usuario.Nome)
                {
                    retorno = u;
                }
            }
            return retorno;
        }

        public Usuario adicionarPermissaoUsuario(Usuario usuario, Ambiente ambiente)
        {
            Usuario retorno = new Usuario();
            foreach (Usuario u in usuarios)
            {
                if (u.Nome == usuario.Nome)
                {
                    u.concederPermissao(ambiente);
                    retorno = u;
                }
            }
            return retorno;
        }

        public Usuario removerPermissaoUsuario(Usuario usuario, Ambiente ambiente)
        {
            Usuario retorno = new Usuario();
            foreach (Usuario u in usuarios)
            {
                if (u.Nome == usuario.Nome)
                {
                    u.revogarPermissao(ambiente);
                    retorno = u;
                }
            }
            return retorno;
        }

        public bool adicionarLog(Usuario usuario, Ambiente ambiente)
        {
            bool suc = false;
            bool per = false;
            foreach (Ambiente a in ambientes)
            {
                if (a.Nome == ambiente.Nome)
                {
                    foreach (Usuario u in usuarios)
                    {
                        if (u.Nome == usuario.Nome)
                        {
                            foreach (Ambiente au in u.Ambientes)
                            {
                                if (au.Nome == a.Nome && suc)
                                {
                                    per = true;
                                }
                            }
                        }
                    }
                    Log log = new Log(DateTime.Now, usuario, per);
                    a.registrarLog(log);
                }
            }

            return per;
        }

        public void adicionarAmbiente(Ambiente ambiente)
        {
            ambientes.Add(ambiente);

        }

        public bool removerAmbiente(Ambiente ambiente)
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

        public Ambiente pesquisarAmbiente(Ambiente ambiente)
        {
            Ambiente retorno = new Ambiente();
            foreach (Ambiente a in ambientes)
            {
                if (a.Nome == ambiente.Nome)
                {
                    retorno = a;
                }
            }
            return retorno;
        }

        public void upload()
        {

        }

        public void download()
        {

        }
    }
}
