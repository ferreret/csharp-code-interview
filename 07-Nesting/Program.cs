int solution(string S)
{

    if (string.IsNullOrEmpty(S))
        return 1;

    int tmp = 0;

    foreach (char c in S)
    {
        if (c == ')' && tmp == 0) return 0;

        if (c == ')')
        {
            tmp--;
        } 
        else
        {
            tmp++;
        }
    }

    return tmp == 0 ? 1 : 0;
}

var res = solution("(()(())())");
Console.WriteLine(res);

var res2 = solution("())");
Console.WriteLine(res2);