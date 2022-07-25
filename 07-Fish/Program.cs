int solution(int[] A, int[] B)
{
    int fishesLeft = 0;
    Stack<int> fishesRight = new Stack<int>();

    for (int i = 0; i < A.Length; i++)
    {
        if (B[i] == 0)
        {
            if (fishesRight.Count == 0)
            {
                fishesLeft++;
            }
            else if (A[i] > fishesRight.Peek())
            {
                while (A[i] > fishesRight.Peek())
                {
                    fishesRight.Pop();
                    if (fishesRight.Count() == 0)
                    {
                        fishesLeft++;
                        break;
                    }
                }
            }
        }
        else
        {
            fishesRight.Push(A[i]);
        }
    }

    return fishesLeft + fishesRight.Count();
}

var res = solution(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 });
Console.WriteLine(res);
