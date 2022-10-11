// See https://aka.ms/new-console-template for more information
using test_deck;

var test = new Permutation(4);
test.PrintPermutations();

Console.WriteLine(test.GetSingle(-1));
Console.WriteLine(test.GetSingle(0));
Console.WriteLine(test.GetSingle(1));
Console.WriteLine(test.GetSingle(23));
Console.WriteLine(test.GetSingle(24));
