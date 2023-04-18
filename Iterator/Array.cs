using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class Array : IAggregator
    {
        private readonly Item[] _items;

        public Array(Item[] items)
        {
            this._items =  items;
        }

        public Item GetItem(int index)
        {
            return _items[index];
        }

        public int GetCount()
        {
            return _items.Length;
        }

        public IIterator Iterator()
        {
            return new ArrayIterator(this);
        }
 
    }
}