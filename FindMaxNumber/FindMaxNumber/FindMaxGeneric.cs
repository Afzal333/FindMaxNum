using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumNumber
{
    public class FindMaxGeneric
    {
        public T FindMax<T>(T a, T b, T c) where T : IComparable
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                return a;
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                return b;
            else
                return c;
        }
    }
}
