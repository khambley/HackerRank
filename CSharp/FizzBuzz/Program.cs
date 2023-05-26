namespace FizzBuzz;

static class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        fizzBuzz(n);
    }
    public static void fizzBuzz(int n)
    {
        for (int i = 1; i <= n; i++)
        {

            bool canBeMultipliedByFive = i.CanBeMultipliedBy(5);
            bool canBeMultipliedByThree = i.CanBeMultipliedBy(3);

            if (canBeMultipliedByFive && canBeMultipliedByThree)
            {

                Console.WriteLine("FizzBuzz");
            }
            else if (canBeMultipliedByThree)
            {

                Console.WriteLine("Fizz");

            }
            else if (canBeMultipliedByFive)
            {

                Console.WriteLine("Buzz");

            }
            else
            {

                Console.WriteLine(i);
            }
        }
    }
    public static bool CanBeMultipliedBy(this int sourceNumber, int targetNumber)
    {

        return (sourceNumber % targetNumber) == 0;
    }

}

