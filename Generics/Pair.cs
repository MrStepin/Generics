﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Pair <T>
    {
        public T First { get; set; }
        public T Second { get; set; }
    }
}
