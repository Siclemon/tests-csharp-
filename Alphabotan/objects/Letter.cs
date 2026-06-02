namespace Objects;

public class Letter
{
    private int index {get;}
    private string answer;
    private string[] art {get;}

    public Letter(int index, string answer, string[] art)
    {
        this.index = index;
        this.answer = answer;
        this.art = art;
    }
}