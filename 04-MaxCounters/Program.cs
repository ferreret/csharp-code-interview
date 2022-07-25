int[] solution(int N, int[] A)
{
    int[] counters = new int[N];

    for (int i = 0; i < A.Length; i++)
    {
        int X = A[i];
        if (X == N + 1)
        {
            Array.Fill(counters, counters.Max());

        }
        else
        {
            counters[X - 1]++;
        }

        Console.WriteLine(String.Join('-', counters));
    }

    return counters;

}

var result = solution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });


