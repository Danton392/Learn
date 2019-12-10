using System;

namespace HWszökőév
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az évet : ");
            int évbekér = int.Parse(Console.ReadLine());
            if (((évbekér % 4 == 0) && (évbekér % 100 != 0)) || (évbekér % 400 == 0)) Console.WriteLine("{0} ez egy szökőév", évbekér);
            else Console.WriteLine("{0} Nem szökőév", évbekér);
            Console.ReadLine();
        
        }
    }
}
