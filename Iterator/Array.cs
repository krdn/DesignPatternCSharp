using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class Array : Aggregator
    {
        private Item[] Items;

        public Array(Item[] items)
        {
            this.Items =  items;
        }

        public Item getItem(int index)
        {
            return Items[index];
        }

        public int getCount()
        {
            return Items.Length;
        }
        Iterator Aggregator.Iterator()
        {
            return new ArrayIterator(this); 
        }
    }
}