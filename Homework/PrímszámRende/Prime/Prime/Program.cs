using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be egy számot, kiderül hogy prím e vagy sem!");
            int bekér = int.Parse(Console.ReadLine());
            int szamlalo = 0;
            for (int i = 1; i == bekér; i++)
            {
                if (bekér % i ==0)
                {
                    szamlalo++;
                }
                
            }
            if (szamlalo == 2)
            {
                Console.WriteLine("Az általad beírt szám PRÍM szám!");
            }
            else
            {
                Console.WriteLine("Az általad beírt szám NEM PRÍM szám!");
            }
        }
    }
}
