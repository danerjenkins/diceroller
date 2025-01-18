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
            for (int i = 0; i < numrolls; i++) { 
                roll = random.Next(1, 7) + random.Next(1, 7);
                rolls[i] = roll;
            }
            return rolls;
        }
    }
}
