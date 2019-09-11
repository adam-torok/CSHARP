using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterek
{
    // Karsa Zoltán: C# programozás - Jegyzet (23. old)
    class Program
    {
        static void Main(string[] args)
        {
            Udvozlet();
            Udvozlet("Szia");

            int a = 2, b = 3;
            SzamKiiras(a, b);
            Console.WriteLine("Két tag összegének négyzete: " +
                Hatvany(ref a, ref b));
            SzamKiiras(a, b);

            bool paros;
            Paros(11, out paros);
            Console.WriteLine(paros);

            string s = "0";
            int sNull;
            bool t = true;
            // Ha igaz, akkor mindig lefut a feltétel
            if (t == true)
            {

            }

            // Példa a kimeneti érték megadására
            if (int.TryParse(s, out sNull))
            {
                Console.WriteLine(sNull.ToString());
            }

            Console.WriteLine("Összeadott értékük: " + Osszeadas(a,b));
            Console.ReadKey();
        }

        // alapértelmezett érték a paraméterben
        static void Udvozlet(string s = "Hello")
        {
            Console.WriteLine(s);
        }

        static void SzamKiiras(int elso, int masodik)
        {
            Console.WriteLine("Első szám: {0}, Második szám: {1}",elso, masodik);
        }

        static int Osszeadas(int elso, int masodik)
        {
            return elso + masodik;
        }

        //Referencia szintű paraméterátadás
        static double Hatvany(ref int elso, ref int masodik)
        {
            elso = 3;
            masodik = 4;

            Console.WriteLine();
            Console.WriteLine($"Új érték: {elso}, {masodik}",elso, masodik);

            // (elso + masodik)^2
            return Math.Pow(elso + masodik, 2);  
        }

        // Kimeneti érték megadása
        static void Paros(int szam, out bool eredmeny)
        {
            // Ha osztható kettővel akkor igaz(true)
            // ?: operátor
            eredmeny = (szam % 2 == 0) ? true : false;
            //if (szam % 2 == 0)
            //{
            //    eredmeny = true;
            //}
            //else
            //{
            //    eredmeny = false;
            //}
        }
    }
}
