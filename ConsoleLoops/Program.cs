namespace ConsoleLoops;

class Program
{
    static void Main(string[] args)
    {
        string[] namearray = new string[] {
            "James",
            "John",
            "Jane",
        };

        for (int i = 0; i < 3; i++) {
            Console.WriteLine(namearray[i]);
        }

        foreach (string name in namearray) {
            Console.WriteLine(name);
        }
        
        
        
        
        /*int i = 0;
        while (i < 3) {
            Console.WriteLine("Loop" + i);
            i++;
        }

        i = 0;
        do
        {
            Console.WriteLine("Do While Loop" + i);
            i++;
        } while (i < 3);
        */
    }
    
}