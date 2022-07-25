int Solution(int[] A)
{
    // int totalElements = A.Length;
    // for (int counter = 1; counter <= A.Length; counter++)
    // {
    //     if (!A.Contains(counter))
    //     {
    //         return counter;
    //     }
    // }
    // return 0;

    var allElements = Enumerable.Range(1, A.Length + 1).ToArray();
    var missing = allElements.Except(A).ToArray();
    return missing[0];

}

Console.WriteLine(Solution(new int[] {2, 3, 1, 5}));
