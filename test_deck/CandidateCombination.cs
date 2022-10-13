using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_deck
{
    internal class CandidateCombination
    {
        int size;
        int select;
        List<string> combinations = new List<string>();

        public CandidateCombination(int select, int size)
        {
            this.select = select;
            this.size = size;
            var src = "";
            for (int i = 0; i < size; i++)
            {
                src += i;
            }
            Console.WriteLine($"\nSet: {src}");
            Console.WriteLine($"Choosing {select} out of {size}\n");
            GenerateCombinations("", src);
        }

        void GenerateCombinations(string build, string src)
        {
            if (build.Length == select)
            {
                combinations.Add(build);
            }
            else
            {
                foreach (char c in src)
                {
                    var _build = build + c;
                    var _src = src.Replace(c.ToString(), "");
                    GenerateCombinations(_build, _src);

                    _build = build;
                    GenerateCombinations(_build, _src);
                    break;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("[");
            foreach (var item in combinations)
            {
                Console.WriteLine("  " + item);
            }
            Console.WriteLine("]");
            Console.WriteLine($"\nNumber of combinations: {combinations.Count}");
        }

    }
}
