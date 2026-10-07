using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NG_jatekok
{
    internal class Jatek
    //Játék neve;Típus;Platform;Kiadás éve;Felhasználói értékelés
    {
        public Jatek(string jatek_neve, string tipus, string platform, int kiadas_eve, double ertekeles)
        {
            Jatek_neve = jatek_neve;
            Tipus = tipus;
            Platform = platform;
            Kiadas_eve = kiadas_eve;
            Ertekeles = ertekeles;
        }

        public string Jatek_neve { get; set; }
        public string Tipus { get; set; }
        public string Platform { get; set; }
        public int Kiadas_eve { get; set; }
        public double Ertekeles { get; set; }
    }
}
