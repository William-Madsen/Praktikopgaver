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

        basePath = $"/Users/williamlundmadsen/Hvoedforlob_1/Mozaar/mozar/{instrument}t";
           

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
        
        SoundPlayer player = new SoundPlayer(path);
        player.PlaySync();
    }
}
