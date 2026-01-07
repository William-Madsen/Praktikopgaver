namespace third_one;

public class Third
{  
    static void Main()
    {
        int year = 2020;
        
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not Leap Year");
        }
    }
}