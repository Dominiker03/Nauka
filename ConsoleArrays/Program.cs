namespace ConsoleArrays;

class Program
{
    static void Main(string[] args)
    {
        int[] numbersArray = { 53, 23, 152 };
        Console.WriteLine(numbersArray.Length);
        Console.WriteLine (numbersArray[0]);
        
        List<int> numbersList = new List<int>();
        numbersList.Add(12);
        Console.WriteLine(numbersList.Count);
        Console.WriteLine(numbersList.Contains(12));

    }
}