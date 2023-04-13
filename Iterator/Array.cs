using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class Array : Aggregator
    {
        private Item[] items;

        public Array(int size)
        {
            items = new Item[size];
        }   

        public Iterator Iterator { get; set; }
    }
}