using System;
namespace Metod_inl_1
{
    class Program
    {
        static int Matte(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 3 heltal");
            Console.WriteLine("Tal 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tal 2");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tal 3");
            int z = Convert.ToInt32(Console.ReadLine());
            int summa = Matte(x,y,z);
            Console.WriteLine("Summan är: "+ summa);
        }
    }
}