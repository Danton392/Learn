using System;

namespace HW_műveleti_jel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írd be az első számot!");
            int bekér1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Írd be a második számot!");
            int bekér2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Írd be a műveleti jelet!");
            string művelet = Console.ReadLine();
            double eredmény = 0;
            switch (művelet)
            {
                case "+": eredmény = bekér1 + bekér2; break;
                case "-": eredmény = bekér1 - bekér2; break;
                case "*": eredmény = bekér1 * bekér2; break;
                case "/": eredmény = bekér1 / bekér2; break;
            }
            Console.WriteLine("Eredmény: " + eredmény);

        }
            
    }
}
