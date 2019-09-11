using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtozok
{
    class Program
    {
        // Reiter István: C# programozás lépésről lépésre (24-27.old)
        // Karsa Zoltán: C# programozás - Jegyzet (3.old)
        static void Main(string[] args)
        {
            int a  = 1, b = 2; //egész szám
            int x; // deklaráció
            x = 10; // definició

            byte bájt = 250; // Előjel nélküli 8 bites egész szám (0.255)
            char karakter = 'X'; // Egy Unicode karkater
            string szoveg = "szöveg";
            bool búúl = true; // Logikai érték true =1, false = 0,
            búúl = Convert.ToBoolean(0);
            float flóath = (float)5/4;
            double dábül = 6 / 2.3; // 15-17 számjegyű pontosságú
            decimal decimál = Convert.ToDecimal(6 / 2.3); // 25-29 pontosság
            // FONTOS: Pénz értékét mindig decimálban tároljuk!

            object obdzsekt = new object(); // inicializálás, minden osztály őse
            var elso = "variéböl"; // variable

            const string alma = "alma"; // Konstans érték

            void Tavasz()
            {
                //alma = "piros alma"; // Konstans értéket nem lehet felülírni
            }

            string semmi = "";
            string nihil = null;

            Console.WriteLine(semmi);
            Console.WriteLine(nihil);
            if (nihil != semmi)
            {
                Console.WriteLine("A null nem egyenértékű a \"\" - jellel");
            }

            Console.ReadKey();

        }
    }
}
