using System;

namespace Three_increasing_adjacent
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays af numbers
            int[] numbers = { 45, 23, 44, 68, 65, 70, 80, 81, 82 };

            // Udskriv om det er sant eller falsk
            bool count = ThreeIncreasingAdjacent(numbers);
            Console.WriteLine("Check if True: " + count);
            
        }

        // Tjekker om arrayet har en sekvens på præcis 3 tal i træk
        static bool ThreeIncreasingAdjacent(int[] values)
        {
            // Arrays der er null eller kortere end 3 kan ikke indeholde sådan en sekvens
            if (values == null || values.Length < 3)
                return false;

            // Skub et vindue på 3 elementer hen over arrayet
            for (int i = 0; i < values.Length - 2; i++)
            {
                // Sammenlign de tre tal: nr. 2 = nr. 1 + 1 og nr. 3 = nr. 2 + 1
                if (values[i + 1] == values[i] + 1 &&
                    values[i + 2] == values[i + 1] + 1)
                {
                    // Fandt en gyldig stigende sekvens
                    return true;
                }
            }

            // Ingen stigende sekvens på længde 3 blev fundet
            return false;
        }
    }
}