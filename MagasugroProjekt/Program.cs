using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MagasugroProjekt.Tarolo;

namespace MagasugroProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Magasugrok magasugroAdatok = new Magasugrok();
            magasugroAdatok.beolvas();

            Console.WriteLine("1. feladat");
            Console.WriteLine("Magasugrók száma: " + magasugroAdatok.getMagasugrokSzama());
            Console.ReadKey();
                
        }
    }
}
