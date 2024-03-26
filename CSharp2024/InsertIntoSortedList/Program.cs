namespace InsertIntoSortedList;

class Program
{
    static void Main(string[] args)
    {
        List<int> array = new List<int>() {4,7,1,3,8,9,12,0,2};

        var newItem = 5;

        array.Sort();

        var index = array.BinarySearch(newItem);

        if (index < 0)
        {
            index = ~index;
        }
        array.Insert(index, newItem);

        for (int i = 0; i < array.Count; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
