using System;
using System.Collections.Generic;

namespace Atividade_12_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cad = new Cadastro();
            int option;

            Console.WriteLine("0. Sair");
            Console.WriteLine("1. Cadastrar ambiente");
            Console.WriteLine("2. Consultar ambiente");
            Console.WriteLine("3. Excluir ambiente");
            Console.WriteLine("4. Cadastrar usuario");
            Console.WriteLine("5. Consultar usuario");
            Console.WriteLine("6. Excluir usuario");
            Console.WriteLine("7. Conceder permissão de acesso ao usuario (informar ambiente e usuário - vincular ambiente ao usuário)");
            Console.WriteLine("8. Revogar permissão de acesso ao usuario (informar ambiente e usuário - desvincular ambiente do usuário)");
            Console.WriteLine("9. Registrar acesso (informar o ambiente e o usuário - registrar o log respectivo)");
            Console.WriteLine("10.  Consultar logs de acesso (informar o ambiente e listar os logs - filtrar por logs autorizados/negados/todos)");
            Console.Write("Escolha uma opção: ");
            option = int.Parse(Console.ReadLine());

            while (option != 0)
            {
                if (option == 1)
                {
                    Console.WriteLine("Digite o nome do Ambiente:");
                    string nome = Console.ReadLine();
                    Ambiente a = new Ambiente();
                    a.Id = cad.Ambientes.Count + 1;
                    a.Nome = nome;
                    a.Logs = new Queue<Log>();

                    cad.adicionarAmbiente(a);

                }
                if (option == 2)
                {
                    Console.WriteLine("Digite o nome do Ambiente:");
                    string nome = Console.ReadLine();
                    Ambiente a = new Ambiente();
                    a.Id = 0;
                    a.Nome = nome;
                    a.Logs = new Queue<Log>();

                    a = cad.pesquisarAmbiente(a);

                    Console.WriteLine("Id do Ambiente: " + a.Id);
                    Console.WriteLine("Nome do Ambiente: " + a.Nome);

                }
                if (option == 3)
                {
                    Console.WriteLine("Digite o nome do Ambiente:");
                    string nome = Console.ReadLine();
                    Ambiente a = new Ambiente();
                    a.Id = 0;
                    a.Nome = nome;
                    a.Logs = new Queue<Log>();

                    if (cad.removerAmbiente(a))
                    {
                        Console.WriteLine("Ambiente removido com Sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Ambiente não foi encontrado!");
                    }

                }
                if (option == 4)
                {
                    Console.WriteLine("Digite o nome do Usuario:");
                    string nome = Console.ReadLine();
                    Usuario u = new Usuario();
                    u.Id = cad.Usuarios.Count + 1;
                    u.Nome = nome;
                    u.Ambientes = new List<Ambiente>();

                    cad.adicionarUsuario(u);


                }
                if (option == 5)
                {
                    Console.WriteLine("Digite o nome do Usuario:");
                    string nome = Console.ReadLine();
                    Usuario u = new Usuario();
                    u.Id = 0;
                    u.Nome = nome;
                    //u.Logs = new Queue<Log>();

                    u = cad.pesquisarUsuario(u);

                    Console.WriteLine("Id do Usuario: " + u.Id);
                    Console.WriteLine("Nome do Usuario: " + u.Nome);

                }
                if (option == 6)
                {
                    Console.WriteLine("Digite o nome do Usuario:");
                    string nome = Console.ReadLine();
                    Usuario u = new Usuario();
                    u.Id = 0;
                    u.Nome = nome;
                    //u.Logs = new Queue<Log>();

                    if (cad.removerUsuario(u))
                    {
                        Console.WriteLine("Usuario removido com Sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Usuario não foi encontrado!");
                    }

                }
                if (option == 7)
                {
                    Usuario u = new Usuario();
                    Ambiente a = new Ambiente();
                    Console.WriteLine("Digite o nome do Usuario:");
                    string nomeu = Console.ReadLine();
                    u.Id = 0;
                    u.Nome = nomeu;
                    u = cad.pesquisarUsuario(u);

                    Console.WriteLine("Digite o nome do Ambiente:");
                    string nomea = Console.ReadLine();
                    a.Id = 0;
                    a.Nome = nomea;
                    a = cad.pesquisarAmbiente(a);

                    cad.adicionarPermissaoUsuario(u, a);

                }
                if (option == 8)
                {
                    Usuario u = new Usuario();
                    Ambiente a = new Ambiente();
                    Console.WriteLine("Digite o nome do Usuario:");
                    string nomeu = Console.ReadLine();
                    u.Id = 0;
                    u.Nome = nomeu;
                    u = cad.pesquisarUsuario(u);

                    Console.WriteLine("Digite o nome do Ambiente:");
                    string nomea = Console.ReadLine();
                    a.Id = 0;
                    a.Nome = nomea;
                    a = cad.pesquisarAmbiente(a);

                    cad.removerPermissaoUsuario(u, a);


                }
                if (option == 9)
                {
                    Usuario u = new Usuario();
                    Ambiente a = new Ambiente();
                    Console.WriteLine("Digite o nome do Usuario:");
                    string nomeu = Console.ReadLine();
                    u.Id = 0;
                    u.Nome = nomeu;
                    u = cad.pesquisarUsuario(u);

                    Console.WriteLine("Digite o nome do Ambiente:");
                    string nomea = Console.ReadLine();
                    a.Id = 0;
                    a.Nome = nomea;
                    a = cad.pesquisarAmbiente(a);

                    cad.adicionarLog(u, a);

                }
                if (option == 10)
                {
                    Ambiente a = new Ambiente();
                    Console.WriteLine("Digite o nome do Ambiente:");
                    string nomea = Console.ReadLine();
                    a.Id = 0;
                    a.Nome = nomea;
                    a = cad.pesquisarAmbiente(a);
                    foreach (Log l in a.Logs)
                    {
                        Console.WriteLine("Data= " + l.DtAcesso + ", NomeUsuario= " + l.Usuario.Nome + ", TeveAcesso= " + l.TipoAcesso);
                    }

                }
                Console.WriteLine("-------------------------------");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Cadastrar ambiente");
                Console.WriteLine("2. Consultar ambiente");
                Console.WriteLine("3. Excluir ambiente");
                Console.WriteLine("4. Cadastrar usuario");
                Console.WriteLine("5. Consultar usuario");
                Console.WriteLine("6. Excluir usuario");
                Console.WriteLine("7. Conceder permissão de acesso ao usuario (informar ambiente e usuário - vincular ambiente ao usuário)");
                Console.WriteLine("8. Revogar permissão de acesso ao usuario (informar ambiente e usuário - desvincular ambiente do usuário)");
                Console.WriteLine("9. Registrar acesso (informar o ambiente e o usuário - registrar o log respectivo)");
                Console.WriteLine("10.  Consultar logs de acesso (informar o ambiente e listar os logs - filtrar por logs autorizados/negados/todos)");
                Console.Write("Escolha uma opção: ");
                option = int.Parse(Console.ReadLine());
            }
        }
    }
}
