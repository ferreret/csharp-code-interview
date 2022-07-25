int solution(int[] A)
{
    int result = 0;
    for (int counter = 1; counter <= A.Length; counter++)
    {
        if (!A.Contains(counter))
        {
            result = counter;
            break;
        }
    }
    return result > 0 ? result : A.Length + 1;
}

Console.WriteLine(solution(new int[] { 1, 2, 6, 4, 1, 2 }));
Console.WriteLine(solution(new int[] { 1, 2, 3 }));
Console.WriteLine(solution(new int[] { -1, -3 }));