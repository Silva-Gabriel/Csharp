using System;
using System.Collections.Generic;

namespace Projeto
{
    class Program
    {
        static List<Contas> ListContas = new List<Contas>();
        static void Main(string[] args)
        {
            Contas MinhaConta = new Contas(TipoDeConta.PessoaFisica, 0, 0, "Gabriel");
            Console.WriteLine(MinhaConta.ToString());
            string EscolhaUsuario = ObterOpcaoDoUsuario();

             while(EscolhaUsuario.ToUpper()!= "X")
            {
                switch (EscolhaUsuario)
                {
                case "1":
                    ListarContas();
                    break;
                case "2":
                    InserirNovaConta();
                    break;
                case "3":
                   Transferir();
                    break;
                case "4":
                    Sacar();
                    break;
                case "5":
                    Depositar();
                    break;
                case "X":
                    Console.WriteLine("LuL banking em inércia,Obrigado por utilizar nossos serviços,para o alto e avante ↑↑☻");
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
                }
                EscolhaUsuario = ObterOpcaoDoUsuario(); 
            }
        }

        private static void InserirNovaConta()
        {
            Console.WriteLine("\nInserir nova Conta");

            Console.Write("Digite 1 para Conta de pessoa física ou 2 para jurídica: ");
            int InputTipoDeConta = Convert.ToInt32(Console.ReadLine());
            while(InputTipoDeConta != 1 && InputTipoDeConta != 2)
            {
                int ContadorDeTentativas = 0;
                Console.WriteLine("Por favor digite 1 para pessoa física ou 2 para pessoa jurídica");
                InputTipoDeConta = Convert.ToInt32(Console.ReadLine());
                if(ContadorDeTentativas > 3)
                {
                    ContadorDeTentativas++;
                    Console.WriteLine("Você excedeu o número de tentativas,tente novamente");
                    throw new ArgumentOutOfRangeException();
                }
            }

            Console.Write("Digite o Nome do Cliente: ");
            string InputNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            double InputSaldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o limite de crédito: ");
            double InputLimiteCredito = Convert.ToDouble(Console.ReadLine());

            Contas NovaConta = new Contas(TipoDeConta: (TipoDeConta)InputTipoDeConta,
                                                        Saldo: InputSaldo,
                                                        Credito: InputLimiteCredito,
                                                        Nome: InputNome);
            //Recebe e adiciona nova conta
            ListContas.Add(NovaConta);
        }

        private static void Depositar()
        {
            Console.Write("Digite o número da conta: ");
            int NumeroDaConta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double ValorDepositado = Convert.ToDouble(Console.ReadLine());

            ListContas[NumeroDaConta].Depositar(ValorDepositado);
        }

        private static void Sacar()
        {
            Console.Write("Digite o número da conta: ");
            int NumeroDaConta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double ValorSacado = Convert.ToDouble(Console.ReadLine());

            ListContas[NumeroDaConta].Sacar(ValorSacado);
        }

        private static void Transferir()
        {
            Console.Write("Digite o número da conta de origem: ");
            int NumeroDaContaDeOrigem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número da conta de destino: ");
            int NumeroDaContaDeDestino = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double ValorDaTransferencia = Convert.ToDouble(Console.ReadLine());

            ListContas[NumeroDaContaDeOrigem].Transferir(ValorDaTransferencia, ListContas[NumeroDaContaDeDestino]);
        }

        private static void ListarContas()
        {
            Console.WriteLine("\nListar contas\n");

            if(ListContas.Count == 0)
            {
                Console.WriteLine("\nNenhuma conta cadastrada.");
                return;
            }
            for(int i = 0; i < ListContas.Count;i++)
            {
                Contas Contas = ListContas[i];
                Console.WriteLine($"#{i} - {Contas}");
            }
        }


        private static string ObterOpcaoDoUsuario()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("--- LuL Banking fora de inércia,como posso ajudar? ---");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("[1] - Listar contas\n[2] - Inserir nova conta\n[3] - Transferir");
            Console.Write("[4] - Sacar\n[5] - Depositar\n[X] - Sair\n");

            Console.Write("\nInforme a opção desejada: ");
            
            string EscolhaUsuario = Console.ReadLine().ToUpper();
            return EscolhaUsuario;
        }
    }
}
