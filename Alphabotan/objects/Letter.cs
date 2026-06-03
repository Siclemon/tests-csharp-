namespace Objects;

public class Letter
{
    public int index {get;}
    public string answer {get; set;}
    public string[] art {get;}

    public Letter(int index, string answer, string[] art)
    {
        this.index = index;
        this.answer = answer;
        this.art = art;
    }
}