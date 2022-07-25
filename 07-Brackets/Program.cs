using System.Collections;

int solution(string S)
{
    var openings = new char[] { '{', '[', '(' };
    var closings = new char[] { '}', ']', ')' };

    Stack<char> stack = new Stack<char>();

    foreach (char c in S)
    {
        if (openings.Contains(c))
        {
            stack.Push(c);
        }
        else if (stack.Count > 0 && (Array.IndexOf(closings, c) == Array.IndexOf(openings, stack.Peek())))
        {
            stack.Pop();
        }
        else
        {
            return 0;
        }
    }

    return stack.Count == 0 ? 1 : 0;

}

var res = solution("{[()()]}");
Console.WriteLine(res);

var res2 = solution("([)()]");
Console.WriteLine(res2);