using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tömb = new int[15];
            Random szam = new Random(); 
            for (int i = 0; i <tömb.Length; i++)
            {
                tömb[i] = szam.Next(0,101);
            }
            Console.Write("Tömb elemei:");
            for (int i = 0; i < tömb.Length; i++)
            {
                Console.Write(" "+tömb[i]);
            }
            Console.WriteLine();
            int max = 0;
            for (int i = 1; i < tömb.Length; i++)
            {
                if (tömb[max]<tömb[i])
                {
                    max = i;
                }
            }
            Console.WriteLine("Tömb legnagyobb eleme: " + tömb[max] + " ,indexe: " + max);

            int min = 0;
            for (int i = 1; i < tömb.Length; i++)
            {
                if (tömb[min] > tömb[i])
                {
                    min = i;
                }
            }
            Console.WriteLine("Tömb legkisebb eleme: " + tömb[min] + " ,indexe: " + min);

        }
    }
}
