using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cegapp;

namespace cegapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alkalmazottak alkalmazott1 = new Alkalmazottak("\"Kovács János", 400000);
            Alkalmazottak menedzer = new Menedzser("Nagy Anna", 600000, 200000);
            Console.WriteLine($"alkalmazott:{alkalmazott1}");
            Console.WriteLine($"menedzser:{menedzer}");

        }
    }
}
