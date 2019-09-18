using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
        
    class Szemely
    {
        public string VezetekNev;
        public string KeresztNev;
        public int IrSzam;
        private string Varos;

        public void SzegediLakos()
        {
            if(IrSzam >= 6719 && IrSzam < 6731)
            {
                Console.Write("Szegedi lakos.");
                Varos = "Szeged";
            }
            else
            {
                Console.WriteLine("Nem szegedi lakos.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //inicializálás, példányosítás - létrehoztuk az objektumot
            Szemely szemely1 = new Szemely();
            szemely1.VezetekNev = "Török";
            szemely1.KeresztNev = "Ádám";
            szemely1.IrSzam = 6600;
            Szemely szemely2 = new Szemely();
            szemely2.VezetekNev = "Teszt";
            szemely2.KeresztNev = "Elek";
            szemely2.IrSzam = 0000;
            Console.WriteLine("Az első személy: {0} {1}",szemely1.VezetekNev, szemely1.KeresztNev);
            Console.WriteLine("Az második személy: {0} {1}", szemely2.VezetekNev, szemely2.KeresztNev);


            Console.Write("Az első személy: ");
            szemely1.SzegediLakos();



            Console.Write("Az második személy: ");
            szemely2.SzegediLakos();

            Console.ReadKey();
        }
    }
}
