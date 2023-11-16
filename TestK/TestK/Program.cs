namespace TestK;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Console.WriteLine("Hello, What is your name?");
        var name = Console.ReadLine();
        Player player = new Player(name);
        Console.WriteLine("who would you like to go against");
        var choice = Console.ReadLine();
        RockPlayer karla = new RockPlayer(name);
        Console.WriteLine("R,P,S");
        var choice2 = Console.ReadLine();

        Console.WriteLine( karla.Value.ToString());


    }



    static void SaySomethingBack(string a)
    {
        


    }


    static void ChooseOpponent()
    {

        Console.WriteLine("Who would you like to player with? RockPlayer/RandomPlater)");
        var choice = Console.ReadLine();


        if(choice == "RP")
        {

        }
        
    }
}

