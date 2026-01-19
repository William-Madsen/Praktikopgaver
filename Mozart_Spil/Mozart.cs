using System;
using System.Media;

class MozartValse
{
    static void Main()
    {
        
        Random rnd = new Random();

        Console.WriteLine("Vælg instrument (Piano, Mbira, Flute-harp eller Clarinet):");
        string input = Console.ReadLine();

        string instrument = "Piano"; // standard
        string basePath;

        if (input == "Piano")
        {
            instrument = "piano";
        }
        else if (input == "Mbira")
        {
            instrument = "mbira";
        }
        else if (input == "Flute-harp")
        {
            instrument = "flute-harp";
        }
        else if (input == "Clarinet")
        {
            instrument = "clarinet";
        }
        else
        {
            Console.WriteLine("Ugyldigt valg, bruger Piano.");
        }

        string basePath = $"/Users/williamlundmadsen/Hvoedforlob_1/Mozaar/mozar/{instrument}t";
        Console.WriteLine($"Valgt instrument: {instrument}");
        Console.WriteLine("Spiller vers...");
           

        // -------- Menuet --------
        for (int frase = 0; frase < 16; frase++)
        {
            int sum = rnd.Next(1, 7) + rnd.Next(1, 7);
            string file = $"{basePath}minuet{frase}-{sum}.wav";

            PlaySound(file);
        }

        // -------- Trio --------
        for (int frase = 0; frase < 16; frase++)
        {
            int dice = rnd.Next(1, 7);
            string file = $"{basePath}trio{frase}-{dice}.wav";

            PlaySound(file);
        }

        Console.WriteLine("Vals færdig");
    }

    static void PlaySound(string path)
    { // hvis jeg var på windows ville dette virker
        
        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName = path,
            UseShellExecute = true
        });
        System.Threading.Thread.Sleep(2000);
    }
}
