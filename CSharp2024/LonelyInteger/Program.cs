namespace LonelyInteger;

class Program
{
    static void Main(string[] args)
    {
        List<int> a = [1,2,3,4,3,2,1];

        Console.WriteLine(LonelyInteger(a));
    }
    public static int LonelyInteger(List<int> a)
    {
       var list = a.GroupBy(x => x).Where(y => y.Count() == 1);
       var element = list.Select(x => x.Key).FirstOrDefault();
       return element;
       //a.GroupBy(x => x).Where(y => y.Count() == 1).Select(y => y.Key).FirstOrDefault();
        
    }
}
