﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public interface Aggregator
    {
        Iterator Iterator { get; set; }
    }
}