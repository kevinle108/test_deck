using test_deck;

//RunPermutations();
//RunCombinations();
RunTestDeck();

static void RunPermutations()
{
    int n = 0;
    string input = "";
    while (input != "x")
    {
        Console.WriteLine("How many rankings to generate permutations for?");
        input = Console.ReadLine();
        int.TryParse(input, out n);

        var test = new RankingPermutation(n);
        test.Print();
        Console.WriteLine("------------------------------------------------");
    }
}

static void RunCombinations()
{
    string input = "";
    int size = 0;
    int select = 0;

    while (input != "x")
    {
        Console.WriteLine("Combination: Enter set size:");
        input = Console.ReadLine();
        int.TryParse(input, out size);
        Console.WriteLine("Enter selection size:");
        input = Console.ReadLine();
        int.TryParse(input, out select);
        var test = new CandidateCombination(select, size);
        test.Print();
        Console.WriteLine("------------------------------------------------\n");
    }
}

static void RunTestDeck()
{
    int ward = 6;
    List<int> contests = new List<int>() { 4, 5};
    var testDeckObj = new TestDeck(ward, contests);
}