using System.Collections;

int solution(int N)
{

    // Let's convert integer to a binary string
    string binary = Convert.ToString(N, 2);
    Console.WriteLine(binary);
    int maxlen = binary.Length;

    if (maxlen < 2) return 0;

    for (int len = maxlen; len >= 2; len--)
    {
        int decimal_number = (int)Math.Pow(2, len) + 1;
        string binary_number = Convert.ToString(decimal_number, 2);
        if (binary.Contains(binary_number))
        {
            Console.WriteLine(binary_number);
            return len - 1;
        }
    }

    return 0;
}

int solution2(int N)
{
    return Convert.ToString(N, 2).Trim('0').Split('1').Max(x => x.Length);
}
Console.WriteLine(solution2(9));
Console.WriteLine(solution2(529));
Console.WriteLine(solution2(20));
Console.WriteLine(solution2(15));


/*
101 --> 5
1001 --> 9
10001 --> 17
100001 --> 33
1000001 --> 65
10000001 --> 129
*/


