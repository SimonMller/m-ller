
string[] kortlista = {"hjärter 2", "hjärter 3", "hjärter 4", "hjärter 5", "hjärter 6", "hjärter 7",
    "hjärter 8", "hjärter 9", "hjärter 10","hjärter knekt", "hjärter dam", "hjärter kung", "hjärter ess" ,"ruter 2",
"ruter 3","ruter 4","ruter 5","ruter 6","ruter 7","ruter 8","ruter 9","ruter 10","ruter knekt","ruter dam"
,"ruter kung","ruter ess","spader 2","spader 3","spader 4","spader 5","spader 6","spader 7","spader 8","spader 9","spader 10",
"spader knekt","spader dam","spader kung","spader ess", "klöver 2","klöver 3","klöver 4","klöver 5","klöver 6","klöver 7",
"klöver 8","klöver 9","klöver 10","klöver knekt","klöver dam","klöver kung","klöver ess",};
Console.WriteLine("hej");
Console.WriteLine("hej");
List<string> cards = new List<string>();
List<string> korthand = new List<string>();
cards.AddRange(kortlista);

Random rand = new Random();



string first = cards[rand.Next(cards.Count)];
cards.Remove(first);
korthand.Add(first);

string second = cards[rand.Next(cards.Count)];
cards.Remove(second);
korthand.Add(second);

string third = cards[rand.Next(cards.Count)];
cards.Remove(third);
korthand.Add(third);

string fourth = cards[rand.Next(cards.Count)];
cards.Remove(fourth);
korthand.Add(fourth);

string fifth = cards[rand.Next(cards.Count)];
cards.Remove(fifth);
korthand.Add(fifth);

korthand.ForEach(Console.WriteLine);


for (int byten = 0; byten < 2; byten++)
{


    if (byten < 2)
    {

        Console.WriteLine("vill du byta några kort");
        var svar = Console.ReadLine();
        if (svar.ToLower() == "ja")


        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("vill du byta kort " + (i + 1) + "?");
                svar = Console.ReadLine();
                if (svar.ToLower() == "ja")
                {
                    korthand[i] = cards[rand.Next(cards.Count)];

                }


            }
            korthand.ForEach(Console.WriteLine);
        }
        else
        {
            byten = 2;
        }    
    }
    
}

List<string> number = new List<string>()
{
    "ess", "2", "3", "4", "5", "6","7","8", "9", "10", "knekt", "dam", "kung"
};
List<string> maxnum = new List<string>();
for(int i = 0; i < 13; i++)
{   
    var count = 0;
    foreach(string s in korthand)
    {
        if (s.EndsWith(number[i])) count++;
    }
    maxnum.Add(count.ToString());
}

var par = 0;
foreach(string s in maxnum)
{
    if (s.EndsWith("2")) par++;
}


var triss = 0;
foreach (string s in maxnum)
{
    if (s.EndsWith("3")) triss++;
}

var fyrtal = 0;
foreach (string s in maxnum)
{
    if (s.EndsWith("4")) fyrtal++;
}


if (fyrtal == 1)
{
    Console.WriteLine("du har fyrtal");
}

if (par == 1 && triss == 1) Console.WriteLine("Du har kåk");
else if (par == 1) Console.WriteLine("Du har par");
else if (par == 2) Console.WriteLine("Du har 2 par");
else if (triss == 1) Console.WriteLine("Du har triss");