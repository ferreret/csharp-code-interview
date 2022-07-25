int solution(int[] A)
{
    int totalEquiLeaders = 0;

    for (int i = 0; i < A.Length - 1; i++)
    {
        var left = A.Take(i + 1);
        var right = A.Skip(i + 1);

        var numLeft = left.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).First();
        var numRight = right.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).First();
        if (numLeft == numRight)
            totalEquiLeaders++;
    }
    return totalEquiLeaders;
}

var res = solution(new int[] { 4, 3, 4, 4, 4, 2 });
Console.WriteLine(res);