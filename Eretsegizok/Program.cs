using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eretsegizok
{
    class Program
    {

        // Struktúra = sor
        public struct Erettsegizo
        {
            public string nev;
            public string tantargy;

        }
        static string filenev = "vizsga.txt";

        static public Erettsegizo[] vizsga = new Erettsegizo[35];
        static public int ErettsegizokSZam()
        {
            return File.ReadAllLines(filenev).Count();
        }
        
        static public void Beolvasas()
        {
            using  (StreamReader sr = new StreamReader(filenev))
            {
                string[] sor = new string[2];
                int index = -1;
                while(sr.Peek() > -1)
                {
                    sor = sr.ReadLine().Split(';');
                    index++;
                    vizsga[index].nev = sor[0]; // sor első eleme lesz a név
                    vizsga[index].tantargy = sor[1];

                }
                //másik megoldás.
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine().Split(';');
                    index++;
                    vizsga[index].nev = sor[0]; // sor első eleme lesz a név
                    vizsga[index].tantargy = sor[1];// sor második eleme les za tantárgy
                }
                // összes sor átalakítása 1 tömbé              
              //  string[] osszesSor = File.ReadAllLines(filenev);
            }
        }

        static public void Kiiratas()
        {
            foreach (Erettsegizo erettsegizo in vizsga)
            {
                Console.WriteLine(erettsegizo.nev + "Vizsgatárgya: "+ erettsegizo.tantargy);
            }
        }

        static void Main(string[] args)
        {
            vizsga = new Erettsegizo[ErettsegizokSZam()];
            Beolvasas();
            Kiiratas();
            Console.ReadKey();
        }
    }
}
