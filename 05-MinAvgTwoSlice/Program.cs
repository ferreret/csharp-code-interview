int solution(int[] A)
{
    int minIndex = 0;
    double minValue = A.Take(2).Sum() / 2; // The mininum has to be length 2
    for (int i = 2; i < A.Length; i++)
    {
        int first = A.Skip(i - 1).Take(1).ToArray()[0];
        int second = A.Skip(i).Take(1).ToArray()[0];

        double tmpValue = ((double)first + (double)second)/2;
        if (tmpValue < minValue)
        {
            minValue = tmpValue;
            minIndex = i - 1;
        }
    }
    return minIndex;
}

var res = solution(new[] { 4, 2, 2, 5, 1, 5, 8 });
Console.WriteLine(res);