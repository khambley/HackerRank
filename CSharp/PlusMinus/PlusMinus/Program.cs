namespace PlusMinus;
class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int posCount = 0;
        int negCount = 0;
        int zeroCount = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 0)
            {
                posCount++;
            }
            else if (arr[i] < 0)
            {
                negCount++;
            }
            else if (arr[i] == 0)
            {
                zeroCount++;
            }
        }

        decimal posValues = (decimal)posCount / arr.Count;
        decimal negValues = (decimal)negCount / arr.Count;
        decimal zeroValues = (decimal)zeroCount / arr.Count;

        Console.WriteLine(String.Format("{0:N6}", posValues));
        Console.WriteLine(String.Format("{0:N6}", negValues));
        Console.WriteLine(String.Format("{0:N6}", zeroValues));
    }

}

