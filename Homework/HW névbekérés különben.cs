using System;

namespace HWKülönben
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írd be a neved a megfelelő köszönéshez:");
            string bekér = Console.ReadLine();
            string megfejetés = "Béla";
            if (bekér == megfejetés) 
            {
                Console.WriteLine("SZIA " + bekér);
                
            }
            else 
            {
                Console.WriteLine("Hello" + bekér);
                Console.ReadLine();
            }
            
            
        }
    }
}
