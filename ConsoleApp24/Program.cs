using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n");
            double n = double.Parse(Console.ReadLine());
            double wynik = 1;
            for (int i = 1; i <= n; i++)
            {
                wynik = wynik * i;
            }
            Console.WriteLine("{0}! wynosi {1} ", n, wynik);
        }
    }
}
