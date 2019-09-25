using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macskapp
{
    class Macska
    {
       public string Nev { get; set; }
       public double Suly { get; set; }
       public bool Ehes { get; set; }

        public Macska(string nev, double suly, bool ehes)
        {
            this.Nev = nev;
            this.Suly = suly;
            this.Ehes = ehes;
        }
        public Macska(string nev, double suly)
        {
            this.Nev = nev;
            this.Suly = suly;
            this.Ehes = true;
        }
        // Ha nem adjuk meg a paramétert, akkor alapértelmezetten 0,2 az érték
        public bool Eszik(double etel = 0.2)
        {
            if(this.Ehes == true)
            {
                this.Suly += etel;
                this.Ehes = false;
                Console.WriteLine("Már nem vagyok éhes");
                Console.WriteLine(this.Nev + " - ennyivel növekedett meg a súlya:" + etel);
                Console.WriteLine("Mostani súlyom:" + Suly);
                 return true;
            }
            else 
            {
                return false;
            }   
        }
        public void futkos()
        {
            if (Ehes == true)
            {
                if (Suly > 1)
                {
                    Suly -= 0.1;

                }
                Ehes = true;

            }
        }

        public override string ToString()
        {
            string ehese;
            if (Ehes)
            {
                 ehese = "éhes";
            }
            else
                 ehese = "nem éhes";
            return Nev +  " a macska, " + Suly + " a súlya, " + "és ő " + ehese ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Macska Kormos = new Macska("Kormos", 5, true);
            Macska Mirci = new Macska("Mirci", 300);
            Mirci.Eszik();
            Mirci.futkos();
            Kormos.futkos();
            Console.WriteLine(Mirci.ToString());
            Console.WriteLine(Kormos.ToString());

            Console.ReadKey();
        }
    }
}
