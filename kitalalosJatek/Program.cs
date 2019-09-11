using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitalalosJatek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözöljük a játékban! \n" +
                "Adjon meg egy kezdő és vég értéket a tartomány megadásához! \n");
            Console.WriteLine("Kérem adja meg kezdőszámot:" );

            int kezdoErtek = 0, vegertek = 0;
            bool isNumber = false;

            while(!isNumber)
            {
                var input = Console.ReadLine();
                if(int.TryParse(input,  out kezdoErtek))
                {
                    isNumber = true;
                }
                else
                {
                    Console.WriteLine("Ez nem sikerült öcsi");
                }
            } 

            isNumber = false;
            Console.WriteLine("Kérem adja meg a végértéket");
            while (!isNumber)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out vegertek))
                {
                    isNumber = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Ez nem sikerült öcsi");
                }
            }


            Random r = new Random();

            int randszam = r.Next(kezdoErtek,vegertek);
            int? tipp = null;
            // A Ciklus addig fog futni amíg nem lesz a tipp egyenlő a véletlen számmal.
            do
            {
                Console.WriteLine("Tip: ");
                tipp = int.Parse(Console.ReadLine());
                //bekérjük a beviteli adatot (string) - átalakítjuk integerré
                if (tipp < randszam)
                {
                    Console.WriteLine("Nagyobb számra gondoltam");
                }
                else if (tipp > randszam)
                {
                    Console.WriteLine("Kissebb számra gondoltam.");
                }else
                {
                    Console.WriteLine("Eltaláltad!");
                }
            } while (tipp!=randszam);
        }
    }
}
