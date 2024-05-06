using System.Collections.Immutable;

namespace DictionaryMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>
            {
                {1, "akordeon" },
                {2, "banan" },
                {3, "cebula" }
            };
            dictionary1.Add(4, "dynia");
            Print(dictionary1);
            Dictionary<int, string> dictionary2 = new Dictionary<int, string>
            {
                [1] = "akordeon",
                [2] = "banan",
                [3] = "cebula"
            };
            dictionary2[4] = "dynia";
            Print(dictionary2);

            int[] arr1 = [1, 2, 3, 4];
            int[] arr2 = [1, 2, 3, 4];
            if(arr1.SequenceEqual(arr2))
            {
                Console.WriteLine("Rowne");
            }
            Dictionary<Winner, string> dictionaryWinner = new Dictionary<Winner, string>(new WinnerEqualityComparer())
            {
                { new Winner("Argentina", new[] {1978, 1986, 2022}), "La Albiceleste"},
                { new Winner("Brazil", new[] {1958, 1962, 1970, 1994, 2002}), "Canarinhos"},
                { new Winner("England", new[]{1970}), "The Three Lions"},
                { new Winner("France", new[]{1998, 2018}), "Les Bleus"},
                { new Winner("Germany", new[] {1954, 1974, 1990, 2014}), "Die Mannschaft"},
                { new Winner("Italy", new[]{1934, 1938, 1982, 2006}), "Azzurri"},
                { new Winner("Spain", new[]{2010}), "La Furia Roja"},
                { new Winner("Uruguay", new[]{1930, 1950}), "Los Charrúas"}
            };
            Print(dictionaryWinner);
        }
        private static void Print<T>(IEnumerable<T> elems)
        {
            foreach(T elem in elems)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
