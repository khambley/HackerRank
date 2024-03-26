namespace CountingSort;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Random random = new Random();
        int randomNumber = 0;

        for(int i = 0; i < 10; i++)
        {
            randomNumber = random.Next(1, 101);
            numbers.Add(randomNumber);
        }
        
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        countingSort(numbers);

    }
    public static List<int> countingSort(List<int> arr)
    {
        List<int> frequencyArray = new List<int>();


        for (int i = 0; i <= 99; i++)
        {
            frequencyArray.Add(0);
        }

        int value = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            value = arr[i];
            frequencyArray[value]++;
        }
        for (int i = 0; i < frequencyArray.Count; i++)
        {
            Console.Write(frequencyArray[i] + " ");
        }
        return frequencyArray;
    }
}
