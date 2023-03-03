using System;

namespace uppgift_61_
{
    public class Adderare
    {
        static void Main(string[] args)
        {
            int summa = Addera(1, 2, 3);
            Console.WriteLine("Svaret är: " + summa);
        }

        static int Addera(int tal1, int tal2, int tal3)
        {
            int summa = tal1 + tal2 + tal3;
            return summa;
        }
    }
}
