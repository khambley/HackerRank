namespace TimeConversion;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(TimeConversion("07:05:45PM"));


    }
    public static string TimeConversion(string s)
    {
        DateTime d = DateTime.Parse(s);
       
        return d.ToString("HH:mm:ss");

    }
}
