using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagasugroProjekt.Modell
{
    class Magasugro
    {
        private string nev;
        private double ugras;

        public string Nev { get => nev; set => nev = value; }
        public double Ugras { get => ugras; set => ugras = value; }

        public Magasugro(string fajlsor)
        {
            string[] adat = fajlsor.Split(';');
            nev = adat[0];
            ugras = Convert.ToDouble(adat[1]);
        }

        public override string ToString()
        {
            return nev + " magasugró " + ugras + " méter magasra ugrott"; ;
        }

        public bool dontobeJutottE()
        {
            if (ugras > 1.4)
                return true;
            else
                return false;
        }
    }
}
