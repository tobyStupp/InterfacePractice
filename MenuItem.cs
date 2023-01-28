using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePracices
{
    class MenuItem
    {
        private string name;
        private double price;
        public MenuItem (string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public string GetName() => name;
        public double GetPrice() => price;
        public override string ToString()
        {
            return $"{name} costs {price}";
        }
    }
}
