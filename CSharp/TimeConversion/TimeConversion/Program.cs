namespace TimeConversion;
class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);


    }
}
class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        DateTime d = DateTime.Parse(s);

        return d.ToString("HH:mm:ss");
    }

}

