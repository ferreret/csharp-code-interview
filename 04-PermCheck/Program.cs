int solution(int[] A)
{
    return A.Length == A.Max() ? 1 : 0;
}

Console.WriteLine(solution(new int[] { 4, 1, 3, 2 }));
Console.WriteLine(solution(new int[] { 4, 1, 3 }));
