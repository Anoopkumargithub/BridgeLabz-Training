using System;
using System.Collections.Generic;
using System.Collections.Specialized;

class VotingSystem
{
    // Stores total votes per candidate
    private Dictionary<string, int> voteCount = new Dictionary<string, int>();

    // Maintains vote order (LinkedHashMap equivalent)
    private OrderedDictionary voteOrder = new OrderedDictionary();

    private int voteId = 1;

    // Cast a vote
    public void CastVote(string candidate)
    {
        // Count votes
        if (voteCount.ContainsKey(candidate))
            voteCount[candidate]++;
        else
            voteCount[candidate] = 1;

        // Maintain insertion order
        voteOrder.Add(voteId++, candidate);
    }

    // Display votes in sorted order
    public void DisplaySortedResults()
    {
        SortedDictionary<string, int> sorted =
            new SortedDictionary<string, int>(voteCount);

        Console.WriteLine("Sorted Results:");
        foreach (var kv in sorted)
            Console.WriteLine($"{kv.Key} : {kv.Value}");
    }

    // Display vote casting order
    public void DisplayVoteOrder()
    {
        Console.WriteLine("Vote Order:");
        foreach (DictionaryEntry entry in voteOrder)
            Console.WriteLine($"Vote {entry.Key} -> {entry.Value}");
    }
}

class Program
{
    static void Main()
    {
        VotingSystem votingSystem = new VotingSystem();

        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Bob");
        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Charlie");
        votingSystem.CastVote("Bob");

        votingSystem.DisplayVoteOrder();
        Console.WriteLine();
        votingSystem.DisplaySortedResults();
    }
}
