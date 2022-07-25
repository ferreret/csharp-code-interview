
int solution(int X, int Y, int D)
{
    return (int)Math.Ceiling(((decimal)Y - (decimal)X) / (decimal)D);
}

Console.WriteLine(solution(10, 85, 30));