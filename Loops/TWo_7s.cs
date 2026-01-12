namespace two_7s;

class Program
{
    static void Main(string[] args)
    {
        int[] number = [9, 2, 5, 7, 9, 0, 7, 7, 3, 1];

        bool tosyver = false;

        for (int i = 0; i < number.Length - 1; i++)
        {
            if (number[i] == 7 && number[i + 1] == 7)
            {
                tosyver = true;
                break;
            }
        }

        Console.WriteLine(tosyver);
    }
}