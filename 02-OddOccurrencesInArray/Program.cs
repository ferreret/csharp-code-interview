using System.Collections;

int solution(int[] A)
{

    return A.GroupBy(x=>x).Where(x=>x.Count()==1).Select(x=>x.Key).First();

}

Console.WriteLine(solution(new int[] { 9, 3, 9, 3, 9, 7, 9 }));

