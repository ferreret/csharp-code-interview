int[] solution(string S, int[] P, int[] Q)
{
    int numberQueries = P.Length;
    var dna = new Dictionary<char, int>() {
        {'A', 1},
        {'C', 2},
        {'G', 3},
        {'T', 4}
    };

    var result = new int[numberQueries];
    var sequence = S.ToArray();

    for (int counter = 0; counter < numberQueries; counter++)
    {
        // int P_Value = P[counter];
        // int Q_Value = Q[Counter];

        result[counter] = Math.Min(dna[sequence[P[counter]]], dna[sequence[Q[counter]]]);
    }
    return result;
}

var result = solution("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 });

foreach (var res in result)
{
    Console.WriteLine(res);
}