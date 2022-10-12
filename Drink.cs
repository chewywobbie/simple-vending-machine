using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step1
{
    class Drink
    {
        string name;
        int price;
        string color;

        public Drink(string name, int price, string color)
        {
            this.Name = name;
            this.Price = price;
            this.Color = color;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
    }
}
