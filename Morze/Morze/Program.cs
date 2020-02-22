using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Morze
{
    class Program
    {
        static public List<morzeABC> abcLista = new List<morzeABC>();
        static public List<Idezet> idezetLista = new List<Idezet>();
        static void Main(string[] args)
        {
            #region 2. feladat
            void abcBeolvasas()
            {
                using (var sr = new StreamReader("../../../Forras/morzeabc.txt", Encoding.UTF8))
                {
                    // Az első sort beolvassa
                    sr.ReadLine();
                    // A fájl végéig olvasson
                    while (!sr.EndOfStream)
                    {
                        var sor = sr.ReadLine();
                        var tomb = sor.Split('\t');
                        var karakter = Convert.ToChar(tomb[0]);
                        var kod = tomb[1];
                        abcLista.Add(new morzeABC(karakter, kod));
                    }
                }
            }
            Console.WriteLine("2. feladat: Beolvasás...");
            abcBeolvasas();
            #endregion

            #region 3. feladat
            var darabszam = abcLista.Count;
            Console.WriteLine("3. feladat: A morze abc {0} karakter kódját tartalmazza.", darabszam);
            #endregion

            #region 4. feladat
            string KarakterKodolas(char karakter)
            {
                // Nagybetűssé alakítás
                karakter = char.ToUpper(karakter);
                // Egy elem visszaadása
                var talalat = abcLista.SingleOrDefault(x => x.Betu == karakter);
                var eredmeny = "Nem található a kódtárban ilyen karakter!";
                if (talalat != null)
                {
                    eredmeny = talalat.Kod;
                }
                return eredmeny;
            }

            Console.WriteLine("4. feladat: Kérek egy karaktert");
            // Bekér egy karaktert, majd értéket az ad inputnak
            var input = Console.ReadKey().KeyChar;
            Console.WriteLine("\nA(z) '{0}' karakter morze kójda: {1}",
                input,
                KarakterKodolas(input));
            #endregion

            #region 6. feladat
            string Morze2Szoveg(string kodoltszoveg)
            {
                // Szöveg felbontása szavakká
                var szavakTomb = kodoltszoveg.Split("       ");
                string eredmeny = null;
                for (int i = 0; i < szavakTomb.Length; i++)
                {
                    // Betűk tömbje = szoTomb
                    var szoTomb = szavakTomb[i].Split("   ");
                    string dekodoltszo = null;
                    foreach (var morzekod in szoTomb)
                    {
                        var betu = abcLista.SingleOrDefault(x => x.Kod == morzekod);
                        if (betu != null)
                        {
                            dekodoltszo += betu.Betu;
                        }
                    }
                    eredmeny += dekodoltszo;
                    if (i < szavakTomb.Length - 1)
                    {
                        eredmeny += " ";
                    }
                }

                return eredmeny;
            }
            #endregion

            #region 5. feladat
            void idezetBeolvasas()
            {
                using (var sr = new StreamReader("../../../Forras/morze.txt", Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        var sor = sr.ReadLine();
                        string[] sorTomb = sor.Split(';');
                        var szerzo = Morze2Szoveg(sorTomb[0]);
                        var idezet = Morze2Szoveg(sorTomb[1]);
                        idezetLista.Add(new Idezet(szerzo, idezet));
                    }
                }
            }

            Console.WriteLine("5. feladat: Beolvasás...");
            idezetBeolvasas();
            #endregion

            #region 7. feladat
            var elsoszerzo = idezetLista.First().Szerzo;
            Console.WriteLine("7. feladat: Az első idézet szerzője: {0}", elsoszerzo);
            #endregion

            #region 8. feladat
            var maxIdezet = idezetLista.OrderByDescending(x => 
                x.Szoveg.Length).First();
            Console.WriteLine("8. feladat: A leghosszabb idézet szerzője és az idézet: {0}: {1}",
                maxIdezet.Szerzo, maxIdezet.Szoveg);
            #endregion

            #region 9. feladat
            Console.WriteLine("9. feladat: Arisztotelész idézetei:");
            var ariLista = idezetLista.Where(x => x.Szerzo == "ARISZTOTELÉSZ").ToList();
            // ToList() alakítás kell előtte a ForEach használatához
            ariLista.ForEach(x => Console.WriteLine("\t - " + x.Szoveg));
            #endregion

            #region 10. feladat
            Console.WriteLine("10. feladat: forditas.txt");
            using (var sw = new StreamWriter("forditas.txt"))
            {
                foreach (var idezet in idezetLista)
                {
                    sw.WriteLine(idezet.Szerzo + ":" + idezet.Szoveg);
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
