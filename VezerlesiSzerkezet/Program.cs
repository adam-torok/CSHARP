using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezerlesiSzerkezet
{
    // Reiter István: C# programozás lépésről lépésre (46-56.old)
    // Karsa Zoltán: C# programozás - Jegyzet (7-12.old)
    class Program
    {
        static void Main(string[] args)
        {
            #region Elagazások: If-else
            var input = Console.ReadLine();

            bool igazE;
            // paraméter szöveg, kimenet logikai érték
            bool.TryParse(input, out igazE);
            //Console.WriteLine(ertek);

            if (igazE)
            {
                Console.WriteLine("A bevitel értéke IGAZ");
            }
            // Vizsgálja, hogy az elemnek 
            // van e értéke és létrejött e
            else if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("A bevitel értéke ÜRES");
            }
            else
            {
                Console.WriteLine("A bevitel értéke HAMIS");
            }

            //LINQ
            var list = new List<string>();
            list.OrderBy(x => x);

            //?:


            //?: Feltételes operátor 2 válaszúttal.
            igazE = bool.TryParse(input, out igazE) ? true : false;
            // if(bool.TryParse(input,out igazE))

            // ?? Null elenőrző operátor.

            input = null;
            igazE = bool.Parse(input ?? "False");
            //Bővítve az előző sor
            if(input == null)
            {
                input = "False";
                igazE = bool.Parse("False");
            }

            #endregion


            #region Elágazások : Switch-case

            Console.WriteLine();
            var honap = DateTime.Now.Month;
            switch (honap)
            {
                case 12:
                case 2:
                case 1:
                    Console.WriteLine("Tél");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Tavasz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Nyár");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Ősz");
                    break;

                default:
                    Console.WriteLine("Nem megfelelő hónap szám");
                    break;
            }



            #endregion
            Console.ReadKey();
            #region Ciklusok : For

            //string[] feladat = new string[3] { "feladat", "megoldás", "válasz" };
            string[] feladat ={ "kérdés", "megoldás", "válasz" };

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 0; j < feladat.Length; j++)
                {
                    Console.WriteLine(i + "." + feladat[j]);
                }
            }

            #endregion
            #region Ciklusok: Foreach
            Console.WriteLine("A helyes sorrend");
            foreach (var item in feladat)
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadKey();
            #endregion
            #region Ciklusok : Do-While

            //hátul tesztelős ciklus

            Console.WriteLine("Kérem adja meg a jelszót");
            var jelszo = "";
            do
            {
                //Karakter bekérése 
                var bill = Console.ReadKey(true);
                if (bill.Key != ConsoleKey.Backspace && bill.Key !=ConsoleKey.Enter)
                {
                    //Karakter hozzáfűzése a "jelszo" változóhoz
                    jelszo += bill.KeyChar;
                    Console.Write("*");
                }
                else
                {

                    //Ha a bevitel törlés gomb és a jelszó változónak már van 0-nál  nagyobb értéke.
                    if(bill.Key == ConsoleKey.Backspace || jelszo.Length > 0)
                    {
                        //kitörlünk egy karakter a végéről
                        jelszo.Substring(0,jelszo.Length-1);
                        Console.Write("\b\b");
                    }
                }

            } while (jelszo != "admin");
            Console.WriteLine();
            Console.WriteLine("Sikeres belépés!");
            #endregion

            #region Ciklusok: While

            Console.WriteLine("A program 5 másodperc mulva bezár");
            // Jelenlegi idő tárolása
            var jelen = DateTime.Now;
            // 5mp hozzáadása.
            var jovo = jelen.AddSeconds(5);
            //amíg a jelenlegi idő el nem éri a jövő időt
            while (jelen < jovo)
            {
                jelen = DateTime.Now;
                Console.WriteLine(DateTime.Now);
            }

            Environment.Exit(0);
            #endregion
        }
    }
}
