namespace diceroller;
internal class Program
{
    private static void Main(string[] args)
    {
        int numrolls;
        int[] rolls;
        int[] rollpercents = {0,0,0,0,0,0,0,0,0,0,0};
        RollDice rd = new RollDice();
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine();
        Console.Write("How many Dice rolls would you like to simulate?  ");
        numrolls = int.Parse(Console.ReadLine());
        Console.WriteLine();
        //Get the rolls by calling the roll class
        rolls = rd.Roll(numrolls);
        for (int i = 0; i < rolls.Length; i++)
        {
            //Count the number for each roll
            rollpercents[rolls[i]-2]++;
        }
        //divide counts by total to get percent
        for (int i = 0; i < rollpercents.Length; i++)
        {
            rollpercents[i] *= 100;
            rollpercents[i] /= numrolls;
        }
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numrolls);
        Console.WriteLine();
        // Print a "*" for each percent per number
        for (int i = 0;i < rollpercents.Length; i++)
        {
            Console.Write(i+2 + ": ");
            for (int j = 0; j < rollpercents[i];j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        
    }
}