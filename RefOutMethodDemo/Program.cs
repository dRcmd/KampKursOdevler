using System;

namespace RefOutMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            int sayimiz = 50; 
            int outSayimiz = 40;
            Topla(ref sayimiz,12);
            Topla2(out outSayimiz,12);

        }

        static void Topla(ref int sayi1, int sayi2)
        {
            //sayi1 = 20;
            Console.WriteLine(sayi1 + sayi2);

        }
        static void Topla2(out int sayi1, int sayi2)
        {
            sayi1 = 10;
            Console.WriteLine(sayi1 + sayi2);

        }
    }
}
