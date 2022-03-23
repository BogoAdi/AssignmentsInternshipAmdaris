using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    public static class MethodExtensions
    {
        public static bool IsItPozitive(this Int32 intu)
        {
            {
                return intu > 0;
            }
        }
        public static int StringLength( this string x)
        {
            return x.Length;
        }
        public static double FractionalPart(this double x)
        {
          return( x>0 ?  x - (int)(x) :  x - (int)(x) + 1);
        }
    }
}
