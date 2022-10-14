using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_deck
{
    internal class RankingPermutation
    {
        List<string> permutations = new List<string>();

        public List<string> Permutations => permutations;

        public RankingPermutation(int n)
        {
            var src = "";
            for (int i = 1; i <= n; i++)
            {
                src += i;
            }
            GeneratePermutations("", src);
        }

        public string GetSingle(int i)
        {
            if (i >= 0 && i < permutations.Count)
            {
                return permutations[i];
            }
            else
            {
                return null;
            }
        }

        void GeneratePermutations( string build, string src)
        {
            if (src.Length == 0)
            {
                permutations.Add(build);           
            }
            else
            {
                foreach (char c in src)
                {
                    var _build = build + c;
                    var _src = src.Replace(c.ToString(), "");
                    GeneratePermutations(_build, _src);
                }
            }            
        }

        public void Print()
        {
            Console.WriteLine("[");
            foreach (var item in permutations)
            {
                Console.WriteLine("  " + item);
            }
            Console.WriteLine("]");
            Console.WriteLine($"\nNumber of permutations: {permutations.Count}");
        }
    }
}
