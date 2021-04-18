using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Problem
{
    public class GenericClass<T> where T : IComparable
    {
        public static T maximum(params T[] elements)
        {
            T max = elements[0];
            foreach (T element in elements)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }
            return max;
        }



    }
}
