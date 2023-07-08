internal class Program
{
    private static void Main(string[] args)
    {

        Random random = new Random();

        // Roll the die and get a random number between 1 and 6
        int diceNumber = random.Next(1, 7);

        Console.WriteLine("The player rolled a " + diceNumber);
    }
}