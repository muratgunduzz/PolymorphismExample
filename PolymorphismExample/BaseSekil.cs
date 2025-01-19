using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    internal class BaseSekil
    {
        public double Genislik {  get; set; }
        public double Yukseklik { get; set; }

        public virtual double Alan()
        {
            return Genislik * Yukseklik;
        }
    }
}
