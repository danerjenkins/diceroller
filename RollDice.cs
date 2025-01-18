using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceroller
{
    public class RollDice
    {
        public int[] Roll(int numrolls) {
            Random random = new Random();
            int[] rolls = new int[numrolls];
            int roll = 0;
            int[] rolltotals = {0,0,0,0,0,0,0,0,0,0,0};
            //generate a list with all the rolls
            for (int i = 0; i < numrolls; i++) { 
                roll = random.Next(1, 7) + random.Next(1, 7);
                rolls[i] = roll;
            }
            //generate a list with the counts of how many times each number was rolled
            for (int i = 0; i < rolls.Length; i++)
            {
                //Count the number for each roll
                rolltotals[rolls[i] - 2]++;
            }
            return rolltotals;
        }
    }
}
