namespace Draw_triangle;

class Program
{
    static void Main(string[] args)
    {
        int height = 5;

        for (int i = 1; i <= height; i++)
        {
            for (int space = 1; space <= height - i; space++)
            {
                Console.Write(" ");
            }

            for (int star = 1; star <= (2 * i - 1); star++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}