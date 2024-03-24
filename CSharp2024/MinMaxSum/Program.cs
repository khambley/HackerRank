namespace MinMaxSum;

class Program
{
    static void Main(string[] args)
    {
        List<int> array = [256741038, 623958417, 467905213, 714532089, 938071625];

        MinMaxSum(array);
    }
    public static void MinMaxSum(List<int> arr){
        // Make sure array is sorted
        arr.Sort();

        // Find Min Sum
        double minSum = 0;
        for (int i = 0; i < arr.Count - 1; i++){
            minSum += arr[i];
        }

        // Find Max Sum
        double maxSum = 0;
        for (int i = arr.Count - 1; i > 0; i--){
            maxSum += arr[i];
        }

        // Print MinSum and MaxSum
        Console.WriteLine($"{minSum} {maxSum}");
    }
}
