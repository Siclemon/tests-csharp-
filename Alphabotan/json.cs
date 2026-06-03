// using System.Text.Json;


// class testjson
// {
    
//     static void Main()
//     {


//         List<Letter> liste = [];

//         string[] art = {" █████ ","██   ██","███████","██   ██","██   ██"};

//         Letter lettre = new(0,"Alpha", art);

//         liste.Add(lettre);

//         string[] art2 = {"██████ ","██   ██","██████ ","██   ██","██████ "};

//         Letter lettre2 = new(1, "Bravo", art2);

//         liste.Add(lettre2);

//         string[] art3 = {" ██████","██     ","██     ","██     "," ██████"};

//         Letter lettre3 = new(2, "Charlie", art3);

//         liste.Add(lettre3);

//         Alphabet alph = new(liste);

//         string jsontruc = JsonSerializer.Serialize(alph);

//         File.WriteAllText("Alphabet.json",jsontruc);
//     }

// }

// [JsonSerializable(typeof(Alphabet))]
// public class Alphabet
// {
//     List<Letter> list {get; set;}

//     public Alphabet(List<Letter> list)
//     {
//         this.list = list;
//     }
// }

// public class Letter
// {
//     private int index {get;}
//     private string answer;
//     private string[] art {get;}

//     public Letter(int index, string answer, string[] art)
//     {
//         this.index = index;
//         this.answer = answer;
//         this.art = art;
//     }
// }