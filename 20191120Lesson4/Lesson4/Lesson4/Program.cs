using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Írd be a négyzetgyök elvégzéséhez szükséges számot: ");
            //int bekér = int.Parse(Console.ReadLine());

            ////int bekér2 = int.Parse(Console.ReadLine());

            //double négyzetgyök = Math.Sqrt(bekér); //math műveletek elvégzéséhez szükséges komplexebb számolások
            //Console.WriteLine("Az általad beírt szám négyzetgyöke: " + négyzetgyök);

            int[] eletkorok = new int[5]; //tömb mérete fix méretű, 5 a valódi méret
            // eletkorok[2] = 5; //tömb második indexű eleme egyenlő 5
           //  Console.WriteLine(eletkorok[2]); // kiiratjuk a tömb második elemét

            for (int i = 0; i < eletkorok.Length; i++) //eletkorok.Length a tömb meghatározott hosszúságáig írja ki 
            {
                Console.WriteLine("Add meg az életkorod");
                eletkorok[i] = int.Parse(Console.ReadLine());
            }
            for (int i = eletkorok.Length-1; i >=0; i--)
            {
                Console.WriteLine(eletkorok[i]);
            }

            foreach (int életkor in eletkorok) //ha minden elemet kell vizsgálni akkor ez végig vizsgálja
            {
                Console.WriteLine(életkor);
            }

            string[,] táblázat=new string[5,10]; //vesszők száma határozza meg a tömb dimenzió méretét
            Console.Write("Sor: ");
            int x =int.Parse (Console.ReadLine());
            Console.Write("Oszlop: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Cella tartalma: ");
            táblázat[x,y] = Console.ReadLine();

            for (int i = 0; i > táblázat.GetLength(0); i++)
            {
                for (int j = 0; j <táblázat.GetLength(1); j++)
                {
                   Console.Write(táblázat[i, j]+ " ");
                }
                Console.WriteLine();
            
            }

        }
    }
}
