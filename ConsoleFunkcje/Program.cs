namespace ConsoleFunkcje{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SayHello("Dominik");
            Console.WriteLine(AddNumbers(5, 6));
            Console.WriteLine(IsPositive(5) + "; " + IsPositive(-2));
        }

        static void SayHello(string playerName)
        {
            Console.WriteLine($"Hello {playerName}!");
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static bool IsPositive(int x)
        {
            if (x >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

