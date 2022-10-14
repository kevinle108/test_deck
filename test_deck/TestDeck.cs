using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_deck
{
    internal class TestDeck
    {
        int ward = 0;
        List<int> contests = new List<int>();
        List<string> lines = new List<string>();

        public TestDeck(int ward, List<int> contests)
        {
            this.ward = ward;
            this.contests = contests;
            GenerateContests();
        }

        void GenerateContests()
        {
            for (int i = 0; i < contests.Count; i++)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"WARD {ward}, CONTEST INDEX {i}");
                GenerateSelections(i, contests[i]);
                System.IO.File.WriteAllLines($"{ward}-{i}.txt", lines);
                lines = new List<string>();
            }
        }

        void GenerateSelections(int contestIndex, int numOfCandidates)
        {
            // create source string representing candidates
            string src = "";
            for (int i = 1; i <= numOfCandidates; i++)
            {
                src += i;
            }
            
            CandidateCombination combinationObj;
            List<string> candidateCombinations; ;
            RankingPermutation rankingObj;
            List<string> rankingPermutations;
            string buildLine = "";
            List<string> candidates;
            List<string> rankings;
            List<string> candidatesWithRank;

            // candidate combinations
            for (int select = 0; select <= numOfCandidates; select++)
            {
                Console.WriteLine($"Choosing {select} out of {numOfCandidates} possible candidates:");

                if (select == 0)
                {
                    buildLine = $"{ward} || {contestIndex}";
                    Console.WriteLine(buildLine);
                    lines.Add(buildLine);
                } else
                {
                    combinationObj = new CandidateCombination(select, numOfCandidates);
                    candidateCombinations = combinationObj.Combinations;

                    // ranking permutations
                    foreach (string candidatesSelected in candidateCombinations)
                    {
                        candidates = candidatesSelected.ToCharArray().Select(c => c.ToString()).ToList();

                        rankingObj = new RankingPermutation(candidatesSelected.Length);
                        rankingPermutations = rankingObj.Permutations;

                        foreach (string rankingArrangement in rankingPermutations)
                        {
                            rankings = rankingArrangement.ToCharArray().Select(c => c.ToString()).ToList();
                            candidatesWithRank = candidates.Zip(rankings, (candidate, ranking) => $"{candidate}-{ranking}").ToList();
                            buildLine = $"{ward} || {contestIndex} | " + String.Join(", ", candidatesWithRank);
                            Console.WriteLine(buildLine);
                            lines.Add(buildLine);
                        }
                    }
                }                
            }
        }
    }
}
