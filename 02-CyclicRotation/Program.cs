int[] solution(int[] A, int K)
{
    int[] result = new int[A.Length];

    for (int i = 0; i < A.Length; i++)
    {
        result[(i + K ) % A.Length] = A[i];
    }

    return result;
}

void printArray(int[] input)
{
    foreach (int value in input)
    {
        Console.Write(value + " ");
    }
    Console.WriteLine();
}

int[] res1 = solution(new int[] { 3, 8, 9, 7, 6 }, 3);
printArray(res1);

int[] res4 = solution(new int[] { 0, 0, 0 }, 3);
printArray(res4);

int[] res5 = solution(new int[] { 1, 2, 3, 4 }, 4);
printArray(res5);



/*

{3 8 9 7 6}
 0 1 2 3 4

{9 7 6 3 8}
 2 3 4 0 1
  
*/