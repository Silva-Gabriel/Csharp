using System;

namespace DividindoXporY
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++) 
            {
                int X = Int32.Parse(Console.ReadLine());
                int Y = Int32.Parse(Console.ReadLine());
                if(Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else if(X == 0)
                {
                    Console.WriteLine("0.0");
                }
                else if(Y != 0)
                {
                    double divisao = X/Y;
                    Console.WriteLine(divisao.ToString(""));
                }
            }
        }
    }
}
