using System;

namespace Lesson5RandomSzám
{
    class Program
    {
        static void Main(string[] args)
        {
            int bekér;
            int számláló = 1;
            Random r = new Random();
            int gondoltszám = r.Next(1, 11);
            do
            {
                számláló++;
                Console.Write("Találd el a gondoltszámot ami 1 és 10 között lehet! Írd be milyen számla gondoltál:");
                bekér = int.Parse(Console.ReadLine());
                if (bekér < gondoltszám)
                {

                    Console.WriteLine("A gondoltszám nagyobb mint amire tippeltél! Próbáld újra!");

                }
                else if (bekér > gondoltszám)
                {

                    Console.WriteLine("A gondoltszám kisebb mint amire tippeltél! Próbáld újra!");

                }
            }
            while (gondoltszám != bekér);
            Console.WriteLine("Szép volt eltaláltad csapd magad falhoz");
            Console.Write("Próbálkozások száma: " + számláló);



        }
    }
}
