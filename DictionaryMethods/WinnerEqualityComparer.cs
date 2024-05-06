using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryMethods
{
    internal class WinnerEqualityComparer : IEqualityComparer<Winner>
    {
        public bool Equals(Winner? x, Winner? y)
        {
            if (Object.ReferenceEquals(x, y))
            {
                return true;
            }
            if (x == null || y == null)
            {
                return false;
            }
            else
            {
                return x.Country == y.Country && x.Years.SequenceEqual(y.Years);
            }
        }
        public int GetHashCode(Winner? x)
        {
            if(x == null)
            {
                return 0;
            }
            else
            {
                int result = 17;
                result = 31 * result + (x.Country == null ? 0 : x.Country.GetHashCode());
                result = 31 * result + (x.Years == null  ? 0 : x.Years.GetHashCode());
                return result;
            }
        }
    }
}
