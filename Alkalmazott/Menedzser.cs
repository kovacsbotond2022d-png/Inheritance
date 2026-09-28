using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cegapp
{
    public class Menedzser : Alkalmazottak
    {
        public int Bonusz { get; set; }
        public Menedzser(string nev,int alapber,int bonusz) : base(nev, alapber)
        {
            Bonusz = bonusz;
        }
        public override int fizetes()
        {
            return alapber + Bonusz;
        }

    }
}
