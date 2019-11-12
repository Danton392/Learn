using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Írj be egy számot: ");
            int szam1 = int.Parse(Console.ReadLine()); // típus konverzió: szöveget számmá alakítja majd belerakja egy számos változóba
            Console.WriteLine(szam1.ToString());

            Console.Write("Írd be a következő számot: ");
            int szam2 = int.Parse(Console.ReadLine()); // típus konverzió: szöveget számmá alakítja majd belerakja egy számos változóba
            Console.WriteLine(szam2.ToString());
            int szamossz = szam1 + szam2;

            Console.WriteLine(szamossz);

            string szoveg1 = szam1.ToString() + szam2.ToString();
            Console.WriteLine(szoveg1);

            Console.WriteLine(++szamossz); //eggyel növeli az értéket ha előtte van

            Console.WriteLine(szam1);

            if (szam1 > szam2 && szamossz == 7) //éssel ha valamelyik feltétel teljesül akkor lefut || Vagy valamelyik feltétel teljesül
            {
                Console.WriteLine("Első szám nagyobb: "+ szam1);
            }
           else if (szam1 < szam2)
            {
                Console.WriteLine("Második szám nagyobb: " + szam2);
            }
            else  
            {
                Console.WriteLine("Két szám egyenlő");
            }


            Console.ReadLine();

        }
    }
}
