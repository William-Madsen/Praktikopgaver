namespace full_sequence_of_letters_M;

class Program
{
    static void Main(string[] args)
    {
        string input = "abcdefghijklmnopqrstuvxyzæøå";

        string ds = "ds";
            
        string[] array = input.Split(new string[] {ds.First().ToString(), ds.Last().ToString()}, StringSplitOptions.None);

        if (array.Length >= 3)
        {
            Console.WriteLine(ds.First() + array[1] + ds.Last());
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}