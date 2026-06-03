
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using Objects;

class Program
{
    
    static void Main()
    {

        List<Letter> alph = JsonSerializer.Deserialize<List<Letter>>(File.ReadAllText("Alphabet.json"));
        Random rng = new();
        List<FallingBlock> fbList = [];
        string[] screen = new string[40];


        Letter lettre = alph[(int)rng.NextInt64(3)];
        FallingBlock fallingBlock = new(25, lettre);

        fbList.Add(NewBlock(alph));
        fbList.Add(NewBlock(alph));
        fbList.Add(NewBlock(alph));


        Console.Clear();
        
        while (true)
        {
            if (rng.Next(100) < 11)
            {
                fbList.Add(NewBlock(alph));
            }
            DisplayBlocks(fbList);
            Thread.Sleep(200);
            Console.Clear();
            Move(fbList);
        }

    }

    static FallingBlock NewBlock(List<Letter> alphabet)
    {
        Random rng = new();
        Letter lettre = alphabet[(int)rng.NextInt64(3)];
        return new FallingBlock((int)rng.NextInt64(16)*10,lettre);
    }

    static void DisplayBlocks(List<FallingBlock> list)
    {
        foreach (FallingBlock fb in list)
        {
            fb.Afficher();
        }
    }

    static void Move(List<FallingBlock> list)
    {
        foreach (FallingBlock fb in list)
        {
            fb.y += 1;
        }
    }

}