using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marka
{
    internal class markak
    {
        public string Marka { get; set; }
        protected int sebesseg; // A gyermekosztály látni fogja

        public markak(string marka)
        {
            Marka = marka;
            sebesseg = 0;
        }

        public virtual void Gyorsit(int ertek)
        {
            sebesseg += ertek;
        }

        public override string ToString()
        {
            return $"Márka: {Marka}, Sebesség: {sebesseg} km/h";
        }

    }
}
