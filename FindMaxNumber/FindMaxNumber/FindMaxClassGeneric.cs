using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxNumber
{
    public class FindMaxClassGeneric<T> where T : IComparable
    {
        public T FindMax(T a, T b, T c)
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
