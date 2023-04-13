using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class Item
    {
        private string name;
        private int cost;

        public Item(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public override string ToString()
        {
            return "(" + name + ", " + cost + ")";
        }
    }
}