#!/usr/bin/env dotnet
class Alphabotan
{
    static void Main()
    {
        string[] alphabet = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        int[] buffer = {100,100,100};
        int t=0;
        int i=0;

        Console.Clear();

        while (true)
        {
            i = NouvelleLettre(buffer);
            buffer = Decale(buffer,i);
            Console.WriteLine(alphabet[i]);
            Thread.Sleep(Math.Max(1000-t,300));
            t += 11;
        }
        
    }

    static private int NouvelleLettre(int[] buffer)
    {
        Random rng = new();
        int i;
        bool ok;

        while (true)
        {
            i = (int)rng.NextInt64(0,26);
            ok = true;

            foreach (int item in buffer)
            {
                if (i == item) ok = false;
            }

            if (ok) return i;
        }
    }
    static private int[] Decale(int[] tab, int nb)
    {
        for (int i = 1; i < tab.GetLength(0); i++)
        {
            tab[i-1] = tab[i];
        }
        tab[tab.GetLength(0)-1] = nb;

        return tab;
    }
}
