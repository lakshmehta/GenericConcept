using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Problem
{
    public class GenericClass<T> where T : IComparable
    {
      
       public static int maximum(int x, int y, int z)
        {
            int max = x;
            if (y.CompareTo(max) > 0)
                max = y;
            if (z.CompareTo(max) > 0)
                max = z;
            return max;
        }
        public static float maximum(float x, float y, float z)
        {
            float max = x;
            if (y.CompareTo(max) > 0)
                max = y;
            if (z.CompareTo(max) > 0)
                max = z;
            return max;
        }
    }
   
}
