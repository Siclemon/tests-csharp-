using Objects;

public class FallingBlock
{
    public int x {get; set;}
    public int y {get; set;}
    public string[] art {get;}
    public string answer {get;}

    public FallingBlock(int x, Letter letter)
    {
        y = 0;
        this.x = x;
        art = letter.art;
        answer = letter.answer;
    }

    public void Afficher()
    {
        for (int i = 0; i < art.Length; i++)
        {
            Console.SetCursorPosition(x, y+i);
            Console.Write(art[i]);
        }
    }
}