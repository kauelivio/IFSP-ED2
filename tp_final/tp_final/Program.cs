using System;

namespace tp_final
{
    class Program
    {
        static void Main(string[] args)
        {
            EquipamentoS equipamentos = new EquipamentoS();
            LocacaoS locacaos = new LocacaoS();
            int option;

            Console.WriteLine("0. Sair");
            Console.WriteLine("1. Cadastrar tipo de equipamento");
            Console.WriteLine("2. Consultar tipo de equipamento (com os respectivos itens cadastrados)");
            Console.WriteLine("3. Cadastrar equipamento (item em um determinado tipo)");
            Console.WriteLine("4. Registrar Contrato de Locação");
            Console.WriteLine("5. Consultar Contratos de Locação (com os respectivos itens contratados)");
            Console.WriteLine("6. Liberar de Contrato de Locação");
            Console.WriteLine("7. Consultar Contratos de Locação liberados (com os respectivos itens)");
            Console.WriteLine("8. Devolver equipamentos de Contrato de Locação liberado");
            Console.Write("Digite uma opção: ");
            option = int.Parse(Console.ReadLine());


            while (option != 0)
            {
                if (option == 1)
                {
                    Console.WriteLine("Digite o tipo de equipamento:");
                    string tipo = Console.ReadLine();
                    TipoEquip te = new TipoEquip();
                    te.Nome = tipo;
                    equipamentos.incluir(te);
                }
                if (option == 2)
                {
                    Console.WriteLine("Digite o tipo de equipamento:");
                    string tipo = Console.ReadLine();
                    TipoEquip te = new TipoEquip();
                    te.Nome = tipo;
                    foreach (TipoEquip t in equipamentos.Estoque)
                    {
                        if (t.Equals(te))
                        {
                            Console.WriteLine("Tipo:" + te.Nome);
                            foreach (Equipamento e in t.Itens)
                            {
                                Console.WriteLine("Id:" + e.Id + " Avariado:" + e.Avaria + " Disponivel:" + e.Locado);
                            }
                        }
                    }
                }
                if (option == 3)
                {
                    Console.WriteLine("Digite o tipo de equipamento:");
                    string tipo = Console.ReadLine();
                    TipoEquip te = new TipoEquip();
                    te.Nome = tipo;
                    foreach (TipoEquip t in equipamentos.Estoque)
                    {
                        if (t.Equals(te))
                        {
                            Console.WriteLine("Quantos equipamentos deseja cadastrar:");
                            int qtdE = int.Parse(Console.ReadLine());
                            for (int i = 0; i < qtdE; i++)
                            {
                                Equipamento e = new Equipamento();
                                e.Locado = false;
                                e.Avaria = false;
                                t.incluir(e);
                            }
                        }
                    }
                }
                if (option == 4)
                {
                    Locacao loc = new Locacao();
                    Console.WriteLine("Digite a data de saida:");
                    string dt_saida = Console.ReadLine();
                    Console.WriteLine("Digite a data de retorno:");
                    string dt_retorno = Console.ReadLine();
                    loc.Data_saida = DateTime.Parse(dt_saida);
                    loc.Data_retorno = DateTime.Parse(dt_retorno);
                    string optC = "";
                    while (optC != "0")
                    {
                        Console.WriteLine("Digite o tipo de equipamento:");
                        string tipo = Console.ReadLine();
                        TipoEquip te = new TipoEquip();
                        te.Nome = tipo;
                        Console.WriteLine("Quantos equipamentos deseja cadastrar:");
                        int qtdE = int.Parse(Console.ReadLine());
                        for (int i = 0; i < qtdE; i++)
                        {
                            Equipamento e = new Equipamento();
                            e.Locado = false;
                            e.Avaria = false;
                            te.incluir(e);
                            foreach (TipoEquip teqp in equipamentos.Estoque)
                            {
                                if (equipamentos.Estoque.Equals(te))
                                {
                                    foreach (Equipamento eqp in teqp.Itens)
                                    {
                                        if (eqp.Equals(e))
                                        {
                                            eqp.Locado = true;
                                        }
                                    }
                                }
                            }
                        }
                        loc.incluir(te);

                        Console.WriteLine("Digite 0 se não quiser cadastrar outro equipamento: ");
                        optC = Console.ReadLine();
                    }

                    locacaos.incluir(loc);
                }
                if (option == 5)
                {
                    Console.WriteLine("Digite o codigo do Contrato:");
                    int lid = int.Parse(Console.ReadLine());
                    Locacao l = new Locacao();
                    l.Id = lid;
                    foreach (Locacao l1 in locacaos.Contratos)
                    {
                        if (l1.Equals(l))
                        {
                            l = l1;
                            foreach (TipoEquip t in l.Itens)
                            {
                                Console.WriteLine("Tipo:" + t.Nome);
                                foreach (Equipamento e in t.Itens)
                                {
                                    Console.WriteLine("Id:" + e.Id + " Avariado:" + e.Avaria + " Alocado:" + e.Locado);

                                }
                            }
                        }
                    }
                }
                if (option == 6)
                {

                    Console.WriteLine("Digite o codigo do Contrato:");
                    int lid = int.Parse(Console.ReadLine());
                    Locacao l = new Locacao();
                    l.Id = lid;
                    foreach (Locacao l1 in locacaos.Contratos)
                    {
                        if (l1.Equals(l))
                        {
                            l1.Liberado = true;
                        }
                    }
                }
                if (option == 7)
                {
                    foreach (Locacao l1 in locacaos.Contratos)
                    {
                        if (l1.Liberado == true)
                        {
                            Console.WriteLine("Id:" + l1.Id + " DataSaida:" + l1.Data_saida + " DataRetorno:" + l1.Data_retorno);
                        }
                        foreach (TipoEquip te in l1.Itens)
                        {
                            Console.WriteLine("Tipo:" + te.Nome);
                            foreach (Equipamento e in te.Itens)
                            {
                                Console.WriteLine("Id:" + e.Id + " Avariado:" + e.Avaria + " Disponivel:" + e.Locado);
                            }
                        }
                    }
                }
                if (option == 8)
                {
                    Console.WriteLine("Digite o codigo do Contrato:");
                    int lid = int.Parse(Console.ReadLine());
                    Locacao l = new Locacao();
                    l.Id = lid;
                    foreach (Locacao l1 in locacaos.Contratos)
                    {
                        if (l1.Equals(l))
                        {
                            l = l1;
                            foreach (TipoEquip t in l.Itens)
                            {
                                foreach (TipoEquip t1 in equipamentos.Estoque)
                                {
                                    if (t == t1)
                                    {
                                        foreach (Equipamento e in t.Itens)
                                        {
                                            foreach (Equipamento e1 in t1.Itens)
                                            {
                                                if (e == e1)
                                                {
                                                    e.Locado = false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Cadastrar tipo de equipamento");
                Console.WriteLine("2. Consultar tipo de equipamento (com os respectivos itens cadastrados)");
                Console.WriteLine("3. Cadastrar equipamento (item em um determinado tipo)");
                Console.WriteLine("4. Registrar Contrato de Locação");
                Console.WriteLine("5. Consultar Contratos de Locação (com os respectivos itens contratados)");
                Console.WriteLine("6. Liberar de Contrato de Locação");
                Console.WriteLine("7. Consultar Contratos de Locação liberados (com os respectivos itens)");
                Console.WriteLine("8. Devolver equipamentos de Contrato de Locação liberado");
                Console.Write("Digite uma opção: ");
                option = int.Parse(Console.ReadLine());
            }
        }
    }
}
