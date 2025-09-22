using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathima
{
    internal class Car
    {
        public string _marka;
        public string _color;
        public int _xiliometra;
        public bool _used;
        public string _pairneimpros;

        public Car(string marka, string color, int xiliometra, bool used, string pairneimpros)
        {
            _marka = marka;
            _color = color;
            _xiliometra = xiliometra;
            _used = used;
            _pairneimpros = pairneimpros;
        }

        public void PrintStats()
        {
            Console.WriteLine($"Marka:{_marka}");
            Console.WriteLine($"Xroma:{_color}");
            Console.WriteLine($"Xiliometra:{_xiliometra}");
            Console.WriteLine($"Used:{_used}");
        }

        public void piremprosta()
        {
            Console.WriteLine($"Pairnei mprosta?{_pairneimpros}");
        }
    }
}
