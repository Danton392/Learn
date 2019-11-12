using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int bekér = -1;
            while (bekér != 5)
            {

                Console.WriteLine("1. Casting");
                Console.WriteLine("2. Orál");
                Console.WriteLine("3. Seggből szájba");
                Console.WriteLine("4. Pisi-Kaki");
                Console.WriteLine("5. Kilépés");
                Console.Write("Kérjük válassz a fenti lehetőségek közül:");
                bekér = int.Parse(Console.ReadLine());

                // if (bekér == 1) 
                // {
                //     Console.WriteLine(" Geci jó vagy vanda");
                // }
                //else if (bekér == 2)
                // {
                //     Console.WriteLine(" Geci jó vagy vanda2");
                // }
                // else if (bekér == 3)
                // {
                //     Console.WriteLine(" Geci jó vagy vanda3");
                // }
                // else if (bekér == 4)
                // {
                //     Console.WriteLine(" Geci jó vagy vanda4");
                // }

                switch (bekér)
                {
                    case 1:
                        Console.WriteLine(" Geci jó vagy vanda");
                        break;
                    case 2:
                        Console.WriteLine(" Geci jó vagy vanda2");
                        break;
                    case 3:
                        Console.WriteLine("Hányszor lesz a seggből szájba?: ");
                        int szamlalo = int.Parse(Console.ReadLine());
                        for (int i = 0; i < szamlalo; i++)
                        {
                            Console.WriteLine("Csokisabb lett a broki");
                        }
                        break;
                    case 4:
                        Console.WriteLine(" Geci jó vagy vanda4");
                        break;

                    default:
                        Console.WriteLine("Élvezd tovább");
                        break;
                }
            }
            Console.WriteLine("Élvezd tovább");
        }
    }
}
