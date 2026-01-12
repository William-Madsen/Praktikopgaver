namespace Extract_string_M;

class Program
{
    static void Main(string[] args)
    {
        string input = ("##abc##def");

        string[] array = input.Split(new string[] { "##" }, StringSplitOptions.None);

        if (array.Length >= 3)
        {
            Console.WriteLine(array[1]);
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}