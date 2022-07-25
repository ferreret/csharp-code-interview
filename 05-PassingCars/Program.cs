int solution(int[] A)
{
    int zeros = 0;
    int pairs = 0;
    for (int counter = 0; counter < A.Length; counter++)
    {
        if (A[counter] == 0)
        {
            zeros++;
        }
        else
        {
            pairs += zeros;
        }
        if (pairs > 1e9)
            return -1;
    }
    return pairs;
}

var res = solution(new int[] { 0, 1, 0, 1, 1 });
Console.WriteLine(res);
