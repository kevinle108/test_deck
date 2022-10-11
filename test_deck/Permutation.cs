﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_deck
{
    internal class Permutation
    {
        public Permutation(int n)
        {
            var src = "";
            for (int i = 1; i <= n; i++)
            {
                src += i;
            }
            GeneratePermutations("", src);
        }

        public List<int> First()
        {
            // TODO
            return new List<int>();
        }

        public List<int> Next()
        {
            // TODO
            return new List<int>();
        }

        void GeneratePermutations(string result, string src)
        {
            if (src.Length <= 1)
            {
                result += src;
                Console.WriteLine(result);
                return;
            }

            foreach (char c in src)
            {
                GeneratePermutations(result + c, src.Replace(c.ToString(), ""));
            }
        }

        public void PrintPermutations(List<string> permutations)
        {
            Console.WriteLine("[ ");
            foreach (var item in permutations)
            {
                string line = "";
                foreach (var number in item)
                {
                    line += $"{number} ";
                }
            }
            Console.WriteLine("]");
        }
    }
}
