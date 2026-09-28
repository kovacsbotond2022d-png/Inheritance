using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cegapp
{
    public class Alkalmazottak
    {
        public string Nev { get; set; }
        protected int alapber { get; set; }

        public Alkalmazottak(string nev,int alapber)
        {
            Nev = nev;
            this.alapber = alapber;
        }
        public virtual int fizetes()
        {
            return alapber;
        }

        public override string ToString()
        {
            return $"Név: {Nev}, Fizetés: {fizetes()} Ft";
        }


    }
}
