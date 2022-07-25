int solution(int A, int B, int K)
{
    return Enumerable.Range(A, B - A).Where(X => X % K == 0).Count();
}

int solution2(int A, int B, int K)
{
    var resta = B - A;
    var mod = A % K;
    return (mod == 0 ? 1 : 0) + (resta) / K;
}

// Console.WriteLine(solution2(6, 11, 2));
// Console.WriteLine(solution2(7, 11, 2));
// Console.WriteLine(solution2(8, 11, 2));
// Console.WriteLine(solution2(9, 11, 2));
// Console.WriteLine(solution2(10, 11, 2));
// Console.WriteLine(solution2(11, 11, 2));

Console.WriteLine(solution2(3, 11, 4));
Console.WriteLine(solution2(7, 11, 4));
Console.WriteLine(solution2(8, 11, 4));
Console.WriteLine(solution2(9, 11, 4));
Console.WriteLine(solution2(10, 11, 4));
Console.WriteLine(solution2(11, 11, 4));