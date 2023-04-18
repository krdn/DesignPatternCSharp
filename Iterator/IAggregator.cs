using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public interface IAggregator
    {
        public IIterator Iterator();
    }
}