using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    internal class Kare : BaseSekil
    {
        public Kare(double yukseklik,double genislik) 
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }
    }
}
