int solution(int[] A)
{
    Array.Sort(A);
    var first3 = A.Take(3).ToArray();
    var last3 = A.Skip(A.Length -3).Take(3).ToArray();

    return Math.Max(first3[0]*first3[1]*first3[2], last3[0]*last3[1]*last3[2]);
}

var res = solution(new int[] { -3, 1, 2, -2, 5, 6 });
Console.WriteLine(res);
