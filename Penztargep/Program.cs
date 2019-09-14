using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penztargep
{
    class Program
    {
        static void Main(string[] args)
        {
            int osszeg = 0;
            string input;

            Console.WriteLine("Üdvözöljük a pénztár programban!");
            Console.WriteLine("Kezdje el az árak bevitelét: ");
            do
            {
                input = Console.ReadLine();
                int resz; // kezdőértéke 0
                // Ha nem sikerül, akkor változatlan a 'resz'
                int.TryParse(input, out resz);
                osszeg += resz;
                // osszeg = osszeg + resz
                // Ha üres akkor az input == ""
                // vagy input != ""
                Console.WriteLine("Eddigi összeg: " + osszeg);
            } while (!string.IsNullOrEmpty(input));

            Console.WriteLine("Végösszeg: " + osszeg);

            Console.ReadKey();
        }
    }
}
