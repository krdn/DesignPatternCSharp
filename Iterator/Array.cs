using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class Array : Aggregator
    {
        private Item[] items { get; set; }

        public Array(Item[] items)
        {
            this.items =  items;
        }   

        public Iterator Iterator { get; set; }
    }
}