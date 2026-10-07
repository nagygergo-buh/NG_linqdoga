using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NG_jatekok
{
    internal class Program
    {
        static List<Jatek> Jatekoklista = new List<Jatek>();
        static void Main(string[] args)
        {
            adatbetolt();
            //adatKiir();
            feladat1();
            feladat2();
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            feladat7();
            feladat8();
            feladat9();
            feladat10();
            feladat11();
            feladat12();
            feladat13();
            feladat14();
            feladat15();

            Console.ReadKey();
        }

       

        private static void feladat15()
        {
            //15
            Console.WriteLine("\nfeladat15:");
            Jatekoklista.GroupBy(x => x.Tipus);
        }
        private static void feladat14()
        {
            //14   
            Console.WriteLine("\nfeladat14:");
        }

        private static void feladat13()
        {
            Console.WriteLine("\nfeladat13:");
            //13
            Jatekoklista.GroupBy(x => x.Tipus).Select(x => new { tipus = x.Key, atlag = x.Average(y => y.Ertekeles) }).ToList().ForEach(k => Console.WriteLine($"{k.tipus,-15} {k.atlag}"));
        }

        private static void feladat12()
        {
            Console.WriteLine("\nfeladat12:");
            //12
            Jatekoklista.Where(x => x.Tipus == "Action").Select(x => new { nev = x.Jatek_neve, ev = x.Kiadas_eve, ertek = x.Ertekeles }).OrderByDescending(x => x.ertek).ToList().ForEach(k => Console.WriteLine($"{k.nev,-50}{k.ev,-5}{k.ertek}"));
        }

        private static void feladat11()
        {
            Console.WriteLine("\nfeladat11:");
            //11
            Jatekoklista.Select(x => new { nev = x.Jatek_neve, ev = x.Kiadas_eve }).ToList().ForEach(k => Console.WriteLine($"{k.nev,-50}{k.ev}"));
        }

        private static void feladat10()
        {
            //10
            Console.WriteLine("\nfeladat10:");
            Console.WriteLine(Jatekoklista.Select(x => x.Tipus).Distinct());
        }

        private static void feladat9()
        {
            Console.WriteLine("\nfeladat9:");
            //9
            Console.WriteLine("legkisseb ertek " +Jatekoklista.Min(x=>x.Ertekeles));
            Console.WriteLine("legnagobb ertek "+Jatekoklista.Max(x=>x.Ertekeles));
        }

        private static void feladat8()
        {
            Console.WriteLine("\nfeladat8:");
            //8
            Jatekoklista.GroupBy(x => x.Platform).Select(x => new { platform = x.Key, db = x.Average(y=>y.Ertekeles) }).OrderByDescending(x => x.db).Take(1).ToList().ForEach(k => Console.WriteLine($"legmagasabb az átlagos értékelés {k.platform} {k.db}"));
        }

        private static void feladat7()
        {
            Console.WriteLine("\nfeladat7:");
            //7
            Console.WriteLine("Jatekok atlag ertekelese: " + Jatekoklista.Average(x => x.Ertekeles));
        }

        private static void feladat6()
        {
            Console.WriteLine("\nfeladat6:");
            //6
            Jatekoklista.GroupBy(x => x.Tipus).Select(x => new { tipus= x.Key, db = x.Count() }).OrderByDescending(x=>x.db).Take(1).ToList().ForEach(k => Console.WriteLine($"{k.tipus} {k.db}"));
        }

        private static void feladat5()
        {
            Console.WriteLine("\nfeladat5:");
            //5
            Jatekoklista.GroupBy(x => x.Platform).Select(x => new { platform = x.Key, db = x.Count() }).ToList().ForEach(k => Console.WriteLine($"{k.platform} {k.db}"));
        }

        private static void feladat4()
        {
            Console.WriteLine("\nfeladat4:");
            //4.feladat
            Jatekoklista.OrderByDescending(x => x.Ertekeles).Take(10).ToList().ForEach(k => Console.WriteLine($"{k.Jatek_neve,-50} {k.Ertekeles}"));
        }

        private static void feladat3()
        {
            Console.WriteLine("\nfeladat3:");
            Jatekoklista.OrderByDescending(x => x.Kiadas_eve).ToList().ForEach(k => Console.WriteLine($"{k.Jatek_neve,-50} {k.Kiadas_eve}"));
        }

        private static void feladat2()
        {
            Console.WriteLine("\nfeladat2:");
            Jatekoklista.Where(x => x.Platform == "Nintendo Switch" && x.Kiadas_eve > 2015 && x.Ertekeles > 8).ToList().ForEach(k => Console.WriteLine($"{k.Jatek_neve,-50} {k.Kiadas_eve,-5} {k.Ertekeles}"));
        }

        private static void feladat1()
        {
            Console.WriteLine("\nfeladat1:");
            Jatekoklista.Where(x => x.Ertekeles > 9).ToList().ForEach(k => Console.WriteLine($"{k.Jatek_neve,-50} {k.Ertekeles}"));
        }

        private static void adatKiir()
        {
            foreach (var item in Jatekoklista)
            {
                Console.WriteLine(item.Jatek_neve);
            }
        }

        private static void adatbetolt()
        {
            Jatekoklista = File.ReadAllLines("jatekok.csv")
            .Skip(1)
            .Select(sor => sor.Split(';'))
            .Select(adat => new Jatek(adat[0], adat[1], adat[2], int.Parse(adat[3]), double.Parse(adat[4])))
            .ToList();
        }
    }
}
