namespace diceroller;
internal class Program
{
    private static void Main(string[] args)
    {
        int numrolls;
        int[] rolltotals;
        RollDice rd = new RollDice();
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine();
        Console.Write("How many Dice rolls would you like to simulate?  ");
        numrolls = int.Parse(Console.ReadLine());
        Console.WriteLine();
        //Get the rolls by calling the roll class
        rolltotals = rd.Roll(numrolls);
        
        //divide counts by total to get percent
        for (int i = 0; i < rolltotals.Length; i++)
        {
            rolltotals[i] *= 100;
            rolltotals[i] /= numrolls;
        }
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numrolls);
        Console.WriteLine();
        // Print a "*" for each percent per number
        for (int i = 0;i < rolltotals.Length; i++)
        {
            Console.Write(i+2 + ": ");
            for (int j = 0; j < rolltotals[i];j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        
    }
}