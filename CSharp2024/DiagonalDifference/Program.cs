namespace DiagonalDifference;

class Program
{
    static void Main(string[] args)
    {
        List<List<int>> intlists = new List<List<int>>();

        List<int> list1 = new List<int>() { -1, 1, -7, -8 };
        List<int> list2 = new List<int>() { -10, -8, -5, -2 };
        List<int> list3 = new List<int>() { 0, 9, 7, -1};
        List<int> list4 = new List<int>() { 4, 4, -2, 1 };

        intlists.Add(list1);
        intlists.Add(list2);
        intlists.Add(list3);
        intlists.Add(list4);

        diagonalDifference(intlists);
    }
    public static int diagonalDifference(List<List<int>> arr)
    {
        var leftDiagSum = 0;
        var rightDiagSum = 0;
        
        var lcounter = 0;
        var rcounter = arr.Count - 1;

        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                if(i == j)
                {
                    leftDiagSum += arr[i][j];
                }
                if(i == lcounter && j == rcounter)
                {
                    rightDiagSum += arr[i][j];
                    lcounter++;
                    rcounter--;
                }
                
                // Print out matrix
                Console.Write($"{arr[i][j]}");
                
                if(j < arr.Count - 1)
                {
                    Console.Write(" ");
                }
                else 
                {
                    Console.WriteLine();
                }
                
            }
        }
        Console.WriteLine($"Array Size: {arr.Count}");
        Console.WriteLine($"LeftDiagonalSum = {leftDiagSum}");
        Console.WriteLine($"RightDiagonalSum = {rightDiagSum}");

        var absDiff = Math.Abs(leftDiagSum - rightDiagSum);

        Console.WriteLine(absDiff);

        return absDiff;
    }
}
