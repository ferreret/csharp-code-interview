int solution(int[] A)
{
    return A.Distinct().Count();
}

int solution2(int[] A)
{
    var tableValues = new HashSet<int>(A);
    return tableValues.Count();
}

var res = solution(new int[] { 2, 1, 1, 2, 3, 1 });
Console.WriteLine(res);

var res2 = solution2(new int[] { 2, 1, 1, 2, 3, 1 });
Console.WriteLine(res2);