namespace UnexpectedDemand;
class Program
{
    /*
     * Complete the 'getTotalGoals' function below.
     *
     * The function is expected to return an INTEGER. Expected Output: 2 
     * The function accepts following parameters:
     *  1. INTEGER number of orders
     *  2. INTEGER(s) list of the number of widgets on the order
     *  3. INTEGER number of orders that can be fulfilled in full.
     *  Example: 2 10 30 40 Output: 2
     */

    static void Main(string[] args)
    {
        // int n = number of orders
        int orderCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> order = new List<int>();

        // number of widgets ordered on each order
        for (int i = 0; i < orderCount; i++)
        {
            int orderItem = Convert.ToInt32(Console.ReadLine().Trim());
            order.Add(orderItem);
        }

        // number of widgets available
        int k = Convert.ToInt32(Console.ReadLine().Trim());

        int result = FilledOrders(order, k);

        Console.WriteLine(result);
    }

    public static int FilledOrders(List<int> order, int k)
    {
        var total = 0;

        foreach (var widgetsOrdered in order)
        {
            if (widgetsOrdered <= k)
            {

                total++;
                k -= widgetsOrdered;
            }
        }
        return total;
    }
}

