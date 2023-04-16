using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class Item
    {
        private string _name;
        private int _cost;

        public Item(string name, int cost)
        {
            this._name = name;
            this._cost = cost;
        }

        public override string ToString()
        {
            return "(" + _name + ", " + _cost + ")";
        }
    }
}