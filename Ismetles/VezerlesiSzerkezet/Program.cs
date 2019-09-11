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

            bool ertek;
            // paraméter szöveg, kimenet logikai érték
            bool.TryParse(input, out ertek);
            //Console.WriteLine(ertek);

            if (ertek)
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
            

            #endregion

            Console.ReadKey();
        }
    }
}
