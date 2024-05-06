using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryMethods
{
    internal class Winner : IEquatable<Winner>
    {
        public string Country { get; set; }
        public int[] Years { get; set; }
        public Winner(string country, int[] years)
        {
            Country = country;
            Years = years;
        }
        public override string ToString()
        {
            string result = Country;
            foreach (int year in Years)
            {
                result += " " + year;
            }
            return result;
        }
        public bool Equals(Winner? other)
        {
            if (other == null)
            {
                return false;
            }
            else if (other == this)
            {
                return true;
            }
            else
            {
                return Country == other.Country && Years.SequenceEqual(other.Years);
            }
        }
    }
}
