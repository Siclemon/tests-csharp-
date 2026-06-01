#!/usr/bin/env dotnet
class Alphabotan
{
    static void Main()
    {
        string[] alphabet = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        Random rng = new Random();

        while (Console.ReadKey(true).Key != ConsoleKey.Escape)
        {
            Console.WriteLine(alphabet[rng.NextInt64(0,26)]);
            
        }
        
    }
}
