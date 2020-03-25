using System;
using System.Collections.Generic;
using System.Text;

namespace IComparable_Implementation
{
    public class HeightComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x?.Height < y?.Height)
                return -1;
            else if (x?.Height > y?.Height)
                return 1;
            else
                return 0;
        }
    }
}
