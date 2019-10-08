using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MagasugroProjekt.Modell;

namespace MagasugroProjekt.Tarolo
{
    class Magasugrok
    {
        List<Magasugro> magasugrok;

        public Magasugrok()
        {
            magasugrok = new List<Magasugro>();
        }

        public void beolvas()
        {
            StreamReader sr=new StreamReader("../../00magasugrok.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Magasugro m = new Magasugro(sor);
                magasugrok.Add(m);
            }
        }

        public int getMagasugrokSzama()
        {
            return magasugrok.Count;
        }

    }
}
