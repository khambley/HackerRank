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
