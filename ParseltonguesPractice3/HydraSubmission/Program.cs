using System;
using System.Linq;

namespace HydraSubmission
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                int[] inputs = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
                int heads = inputs[0];
                int tails = inputs[1];

                if (heads == 0 && tails == 0)
                {
                    keepGoing = false;
                    break;
                }
                else
                {
                    Console.WriteLine(KillHydra(heads, tails));
                }
            }
        }

        public static int KillHydra(int heads, int tails)
        {
            if (tails == 0 && heads % 2 == 1)
            {
                return -1;
            }
            else
            {
                int count = 0;

                // add tails until we can "finish" hydra
                // Hydra is finishable when heads is divisible by 2
                // AND Tails is 
                // Tails convert to Heads at a rate of 2 to 1
                if (heads % 2 == 1)
                {
                    // Heads odd, need to add one head
                    // Add tails until the remainder when dividing by 4 is 2
                    // Remainder 2 to convert into 1 head
                    // Divide by 4 because Tails has to be even to be completely eliminated and won't affect even/odd of Heads
                    while (tails % 4 != 2)
                    {
                        tails++;
                        count++;
                    }
                }
                else
                {
                    // Heads is even
                    // Add tails until the remainder when dividing by 4 is 0
                    while (tails % 4 != 0)
                    {
                        tails++;
                        count++;
                    }
                }

                // convert the tails into heads => heads will be even

                heads += (tails / 2);
                count += tails / 2;


                // cut off all the heads
                count += heads / 2;

                return count;
            }
        }
    }
}
