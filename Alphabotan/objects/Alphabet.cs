using System.Collections;

namespace Objects;

public class Alphabet
{
    public string id {get;}
    public List<Letter> list {get; set;}

    public Alphabet(List<Letter> list, string id)
    {
        this.list = list;
        this.id = id;
    }
}
