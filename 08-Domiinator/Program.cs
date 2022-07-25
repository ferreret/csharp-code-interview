int solution(int[] A)
{
    var tmp = A.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).First();

    return Array.IndexOf(A, tmp);
}

int solution2(int[] A)
{
    int n = A.Length;
    int size = 0;
    int value = 0;
    Stack<int> s = new Stack<int>();

    for (int i = 0; i < n; i++)
    {
        if (size == 0)
        {
            size += 1;
            Console.WriteLine(A[i]);
            s.Push(A[i]);
        }
        else
        {
            Console.WriteLine(s.Peek());
            Console.WriteLine(A[i]);
            if (s.Peek() != A[i]) size -= 1;
            else size += 1;
        }
    }
    int candidate = -1;
    if (size > 0) candidate = s.Peek();
    int count = 0;
    int leader = -1;

    for (int i = 0; i < n; i++)
    {
        if (A[i] == candidate) count += 1;
        if (count > n / 2) leader = candidate;
    }

    return Array.IndexOf(A, leader);
}

var res = solution2(new int[] { 4, 7, 3, 4, 3, 2, 3, -1, 3, 3 });
Console.WriteLine(res);

