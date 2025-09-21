using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathima
{
    internal class Item
    {
        private string _name;
        private float _price;

        public Item(string name, float price)
        {
            _name = name;
            _price = price;
        }

        public void PrintStats()
        {
            Console.WriteLine($"Onoma:{_name}");
            Console.WriteLine($"Timi:{_price}€");
            Console.WriteLine();
        }
    }
}
