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
            Magasugrok magasugrok = new Magasugrok();
            magasugrok.beolvas();

            Console.WriteLine("1. feladat");
            Console.WriteLine("Magasugrók száma: " + magasugrok.getMagasugrokSzama());
            Console.ReadKey();
                
        }
    }
}
