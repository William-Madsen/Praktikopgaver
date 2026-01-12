namespace Sum_and_average;

class Program
{
    static void Main(string[] args)
    {
        int n = 11;
        int m = 66;
        
        long conut = (long)m - n + 1;
        long sum = conut * (2L * n + (conut - 1)) / 2;
        double average = (double)sum /conut;
        Console.WriteLine("sum: "+  sum + " , average: " + average);
    }
}