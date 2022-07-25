int Solution(int X, int[] A) 
{
    return Array.IndexOf(A.Skip(1).ToArray(), X) + 1;
}

Console.WriteLine(Solution(5, new int[] { 1, 3, 1, 4, 2, 3 ,5 ,4 }));
