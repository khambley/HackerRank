namespace MiniMax_Sum;
class Program
{
    static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     * 
     */

    public static void miniMaxSum(List<int> arr)
    {
        
        long sum1 = 0;
        long sum2 = 0;
        long sum3 = 0;
        long sum4 = 0;
        long sum5 = 0;

        // skip first value
        for (int i = 1; i <= arr.Count - 4; i++)
        {
            //Convert.ToInt64(sum1);
            sum1 = SumValues(arr[i], arr[i + 1], arr[i + 2], arr[i + 3]);

            Console.WriteLine($"{arr[i]} + {arr[i + 1]} + {arr[i + 2]} + {arr[i + 3]} = {sum1}");

        }
        //Console.WriteLine(sum1);
       
        for (int i = 0; i <= arr.Count - 5; i++)
        {
            // skip second value
            //Convert.ToInt64(sum2);
            sum2 = SumValues(arr[i], arr[i + 2], arr[i + 3], arr[i + 4]);
            //Console.WriteLine($"{arr[i]} + {arr[i + 2]} + {arr[i + 3]} + {arr[i + 4]} = {sum2}");

            // skip third value
            //Convert.ToInt64(sum3);
            sum3 = SumValues(arr[i], arr[i + 1], arr[i + 3], arr[i + 4]);
            //Console.WriteLine($"{arr[i]} + {arr[i + 1]} + {arr[i + 3]} + {arr[i + 4]} = {sum3}");

            // skip fourth value
            //Convert.ToInt64(sum4);
            sum4 = SumValues(arr[i], arr[i + 1], arr[i + 2], arr[i + 4]);
            //Console.WriteLine($"{arr[i]} + {arr[i + 1]} + {arr[i + 2]} + {arr[i + 4]} = {sum4}");

            // skip fifth value
            //Convert.ToInt64(sum5);
            sum5 = SumValues(arr[i], arr[i + 1], arr[i + 2], arr[i + 3]);
            //Console.WriteLine($"{arr[i]} + {arr[i + 1]} + {arr[i + 2]} + {arr[i + 3]} = {sum5}");

        }
        var sums = new List<long>();

        sums.Add(sum1);
        sums.Add(sum2);
        sums.Add(sum3);
        sums.Add(sum4);
        sums.Add(sum5);

        var minValue = sums.Min();
        var maxValue = sums.Max();

        Console.Write(minValue);
        Console.Write(" ");
        Console.Write(maxValue);

        //Console.WriteLine(sum2);
        //Console.WriteLine(sum3);
        //Console.WriteLine(sum4);
        //Console.WriteLine(sum5);

    }

    public static long SumValues(long val1, long val2, long val3, long val4)
    {
        return val1 + val2 + val3 + val4;
    }

}

