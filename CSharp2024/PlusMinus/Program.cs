/* PlusMinus: Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
Print the decimal value of each fraction on a new line with  places after the decimal.
plusMinus has the following parameter(s):
int arr[n]: an array of integers

Print
Print the ratios of positive, negative and zero values in the array.
Each value should be printed on a separate line with  digits after the decimal. The function should not return a value.

Input Format
The first line contains an integer, , the size of the array.
The second line contains  space-separated integers that describe .
*/

namespace PlusMinus;

class Program
{
    static void Main(string[] args)
    {
        List<int> array = [1,1,0,1,1];

        plusMinus(array);
    }
    public static void plusMinus(List<int> arr)
    {
        var posCount = 0;
        var negCount = 0;
        var zeroCount = 0;
        for(int i = 0; i < arr.Count; i++)
        {
            if ( arr[i] > 0 ){
                posCount++;
            }
            else if ( arr[i] < 0 ){
                negCount++;
            }
            else {
                zeroCount++;
            }
        }
        if(posCount > 0){
                double posRatio = posCount / (double)arr.Count;
                Console.WriteLine(posRatio.ToString("N6"));
            }
            else {
                Console.WriteLine("0.000000");
            }

            if(negCount > 0){
                var negRatio = negCount / (double)arr.Count;
                Console.WriteLine(negRatio.ToString("N6"));
            }
            else {
                Console.WriteLine("0.000000");
            }

            if(zeroCount > 0){
                var zeroRatio = zeroCount / (double)arr.Count;
                Console.WriteLine(zeroRatio.ToString("N6"));
            }
            else {
                Console.WriteLine("0.000000");
            }
    }
}
