using test_deck;

RunTestDeck();

static void RunTestDeck()
{
    var ward1 = new TestDeck(1, new List<int>() { 6, 2 });

    var ward2 = new TestDeck(2, new List<int>() { 6, 2});

    var ward3 = new TestDeck(3, new List<int>() { 6, 3});

    var ward4 = new TestDeck(4, new List<int>() { 6, 2});

    var ward5 = new TestDeck(5, new List<int>() { 6, 3});

    var ward6 = new TestDeck(6, new List<int>() { 6, 2});
}












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