using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public interface IIterator
    {
        bool Next();
        object Current();
    }
}