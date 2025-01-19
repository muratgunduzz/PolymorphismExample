using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    internal class Ucgen : BaseSekil
    {
        public Ucgen(double genislik, double yukseklik) 
        { 
           Genislik = genislik;
           Yukseklik = yukseklik;
        }
        public override double Alan()
        {
            return 0.5 * Genislik * Yukseklik;
        }
    }
}
