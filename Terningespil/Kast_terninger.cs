namespace Terningespil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hvor mange terninger skal der være? ");
            int antalTerninger = int.Parse(Console.ReadLine());

            Random random = new Random();
            int antalKast = 0;
            bool alleSeksere = false;

            while (!alleSeksere)
            {
                antalKast++;
                alleSeksere = true;

                Console.Write("Kast " + antalKast + ": ");

                for (int i = 0; i < antalTerninger; i++)
                {
                    int slag = random.Next(1, 7);
                    Console.Write(slag + " ");

                    if (slag != 6)
                    {
                        alleSeksere = false;
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nDet tog {antalKast} kast at slå rene seksere!");
        }
    }
}