using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_deck
{
    internal class Permutation
    {
        List<string> permutations = new List<string>();

        public Permutation(int n)
        {
            var src = "";
            for (int i = 1; i <= n; i++)
            {
                src += i;
            }
            List<string> result = new List<string>();
            GeneratePermutations(result, "", src);
            permutations = result;
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

        List<string> GeneratePermutations(List<string> results, string build, string src)
        {
            if (src.Length <= 1)
            {                
                results.Add(build += src);
                return new List<string>();
            }

            foreach (char c in src)
            {
                var _build = build + c;
                var _src = src.Replace(c.ToString(), "");
                GeneratePermutations(results, _build, _src);
            }
            return results;
        }

        public void PrintPermutations()
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
