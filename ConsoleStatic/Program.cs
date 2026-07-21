namespace ConsoleClass;

class Program
{
    static void Main(string[] args)
    {
       /*
        int age = 56;
        Player player = new Player("Dominiker");
        player.SayHello();
        Player Dominikplayer = new Player("Koks");
        Dominikplayer.SayHello();
        */
       Player.SayHello();
       new Player("Code Monkey");
       Player.SayHello();
       new Player("Koks");
    }

    class Player
    {
        public static string name = "-";
        public Player(string name)
        {
            Player.name = name;
            Console.WriteLine($"Creating player {name}");
        }

        public static void SayHello()
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}