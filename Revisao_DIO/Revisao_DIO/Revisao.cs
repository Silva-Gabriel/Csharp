using System;

namespace Revisao_DIO
{
    class Revisao
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string EscolhaUsuario = ObterEscolhaDoUsuario();

            while(EscolhaUsuario != "4")
            {
                switch (EscolhaUsuario)
                {
                    case "1":
                        Console.Write("\nInforme o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        
                        Console.Write("\nInforme a nota do aluno: ");
                        
                        //Se for decimal irá preencher a variável nota
                        if(decimal.TryParse(Console.ReadLine(),out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("O valor da nota deve ser decimal!");
                        }
                    
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                            //Se o nome não for vazio ele imprime o nome
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine("================================");
                                Console.WriteLine($"ALUNO: {a.Nome}\nNOTA: {a.Nota}");
                                Console.WriteLine("================================\n\n");
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var numeroDeAlunos = 0;
                        for(int i = 0;i < alunos.Length;i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                numeroDeAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal / numeroDeAlunos;
                        Conceito conceitoGeral;
                        if(mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if(mediaGeral < 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if(mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if(mediaGeral < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.Write("\n===========================");
                        Console.WriteLine($"\nMÉDIA GERAL: {mediaGeral}\nCONCEITO GERAL: {conceitoGeral}");
                        Console.WriteLine("===========================\n");
                        break;
                    default:
                    throw new ArgumentOutOfRangeException();

                }
                EscolhaUsuario = ObterEscolhaDoUsuario();
            }
        }
        private static string ObterEscolhaDoUsuario()
        {
            Console.WriteLine("\n*********Cadastro De Alunos*********");
            Console.WriteLine("\nInforme a opção desejada: ");
            Console.Write("\n[1] Inserir novo aluno\n[2] Listar alunos\n[3] Calcular média geral do aluno\n[4] Sair");
            Console.Write("\nSua escolha: ");

            string EscolhaUsuario = Console.ReadLine();
            return EscolhaUsuario;
        }

         //Estrutura simples não necessita ser class,mas é o ideal
            public struct Aluno
            {
                public string Nome { get; set; }
        
                public  decimal Nota { get; set; }
            }

            public enum Conceito
            {
                A,

                B,

                C,

                D,

                E
            }

    }
}
