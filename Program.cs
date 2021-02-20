using System;

namespace DIO_DOT_NET
{
    class Program
    {
        static void Main()
        {
           int[] a = new int[5];
        for(int i = 0;i < 5;i++)
            a[i] =  Int32.Parse(Console.ReadLine());
        for(int i = 0; i < 5; i++)
            Console.Write(a[i]+" ");
        }
        

    }
}
