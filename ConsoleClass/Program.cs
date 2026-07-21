namespace ConsoleClass;

class Program
{
    static void Main(string[] args)
    {
        int age = 56;
        Player player = new Player("Dominiker");
        player.SayHello();
        Player Dominikplayer = new Player("Koks");
        Dominikplayer.SayHello();
    }

    class Player
    {
        public string name = "-";
       public Player(string name)
       {
           this.name = name;
            Console.WriteLine($"Creating player {name}");
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}