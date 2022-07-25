int Solution(int[] A)
{
    int totalElements = A.Length;
    int minDiff = -1;

    for (int P = 1; P < A.Length; P++)
    {
        int diff = Math.Abs(A.Skip(P).Sum() - A.Take(P).Sum());

        if (minDiff == -1 || diff < minDiff)
        {
            minDiff = diff;
        }
    }

    return minDiff;

}

Console.WriteLine(Solution(new int[] { 3, 1, 2, 4, 3 }));