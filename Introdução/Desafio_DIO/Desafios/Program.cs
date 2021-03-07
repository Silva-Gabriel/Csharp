using System;
using System.Globalization;

namespace teste2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("[1]Media de consumo de um automóvel\n[2]Identificando o ddd\n[3]Reajuste de salário");
            Console.Write("Digite sua opção: ");
            int escolha = Int32.Parse(Console.ReadLine()); 
            switch (escolha)
            {
                case 1:
                    MediaDeConsumo();
                    break;
                case 2:
                    ddd();
                    break;
                case 3:
                    ReajusteDoSalario();
                    break;
                default:
                    Console.WriteLine("Tenha um bom dia!");
                    break;
            }
                static void MediaDeConsumo()
                {
                    int X;
                    double Y,ConsumoMedio;
                    string ConsumoMedioTotal;
                    
                    Console.Write("Digite a distância percorrida: ");
                    X = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite a quantidade em litros gasta: ");
                    Y = Convert.ToDouble(Console.ReadLine());
                    Y = Math.Round(Y,1);

                    ConsumoMedio = X / Y;
                    ConsumoMedio = Math.Round(ConsumoMedio,3);
                    ConsumoMedioTotal = Convert.ToString(ConsumoMedio);
                    ConsumoMedioTotal = ConsumoMedioTotal.Replace(",",".");

                    Console.WriteLine($"{ConsumoMedioTotal} km/l");
                }

                static void ddd()
                {
                    int ddd = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("[61] Brasilia\n[71]Salvador\n[11]São paulo\n[21]Rio de Janeiro\n[32]Juiz de Fora\n[19]Campinas\n[27]Vitória\n[31]Belo Horizonte");
                    switch (ddd)
                    {
                        case 61:
                            Console.WriteLine("Você escolheu Brasilia");
                            break;
                        case 71:
                            Console.WriteLine("Você escolheu Salvador");
                            break;
                        case 11:
                            Console.WriteLine("Você escolheu São Paulo");
                            break;
                        case 21:
                            Console.WriteLine("Você escolheu Rio de Janeiro");
                            break;
                        case 32:
                            Console.WriteLine("Você escolheu Juiz de Fora");
                            break;
                        case 19:
                            Console.WriteLine("Você escolheu Campinas");
                            break;
                        case 27:
                            Console.WriteLine("Você escolheu Vitória");
                            break;
                        case 31:
                            Console.WriteLine("Você escolheu Belo Horizonte");
                            break;
                        default:
                            Console.WriteLine("DDD nao cadastrado");
                            break;
                    }
                
                }
                static void ReajusteDoSalario()
                {
                    double salario= -10,novoSalario = 0.00,reajuste = 0.00,percentual = 0;

                    Console.Write("Digite o seu salário atual: ");
                    salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    if (salario < 0.00)
                    {
                        return;
                    }
                    else if (salario <= 400.00)
                    {
                        percentual = 15;
                        reajuste = salario * ((double)percentual / 100);
                        novoSalario = salario + reajuste;
                    }
                    else if (salario <= 800.00)
                    {
                        percentual = 12;
                        reajuste = salario * ((double)percentual / 100);
                        novoSalario = salario + reajuste;
                    }

                    else if (salario <= 1200.00)

                    {
                        percentual = 10;

                        reajuste = salario * ((double)percentual / 100);

                        novoSalario = salario + reajuste;
                    }
                    else if (salario <= 2000.00)
                    {
                        percentual = 7;
                        reajuste = salario * ((double)percentual / 100);
                        novoSalario = salario + reajuste;
                    }
                    else
                    {
                        percentual = 4;
                        reajuste = salario * ((double)percentual / 100);
                        novoSalario = salario + reajuste;
                    }
                    Console.WriteLine("Novo salario: {0}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Em percentual: {0} %", percentual);
                }
        }
    }
}


