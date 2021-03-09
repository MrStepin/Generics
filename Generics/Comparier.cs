using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Comparier
    {
        public bool Compare<T>(T first, T second) where T : IEquatable<T>
        {
            if (first.Equals(second))
            {
                return true;
            }
            return false;
        }
    }
}
