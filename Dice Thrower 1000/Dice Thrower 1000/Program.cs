using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Thrower_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            diceCOunter1000("2n0 3d7 2d1");
            Console.ReadKey();
        }

        static void diceCOunter1000(string input)
        {
            //Creates random number
            Random rng = new Random();
            //List to record rolls
            List<int> recordedRolls = new List<int>();
            //Creates list of the DiceNotation, accomodates multipule dice/rolls
            List<string> diceMasterList = input.Split(' ').ToList();
            //Loops list containing dice
            for (int i = 0; i < diceMasterList.Count(); i++)
            {
                //creates list that uses parseDice function to seperate dice data into two spots
                List<int> diceDataToUse = parseDice(diceMasterList[i]);
                if (diceDataToUse == null)
                {
                    Console.WriteLine("You entered data that doesn't make sense: " + diceMasterList[i] + "\n");
                }
                else
                {
                    //uses this list to set values of number of rolls and number of sides
                    int numOfRolls = diceDataToUse[0];
                    int numOfSides = diceDataToUse[1];
                    //for loop that loops for the number of sides
                    for (int j = 0; j < numOfRolls; j++)
                    {
                        //gets random number using the number of sides on the die
                        int thisRollValue = rng.Next(1, numOfSides + 1);
                        //records the roll number into the list of recorded rolls
                        recordedRolls.Add(thisRollValue);
                    }
                    //The output
                    Console.WriteLine("When I rolled " + diceMasterList[i] + ", my rolls were:");
                    foreach (int item in recordedRolls)
                    {
                        Console.Write(item + ", ");
                    }
                    Console.WriteLine("and the average of those was: " + Math.Round(recordedRolls.Average(), 3));
                    Console.WriteLine();
                    //clears recorded rolls list to be used in the next iteration of the for loop
                    recordedRolls.Clear();
                }
            }
        }
        /// <summary>
        /// Data converstion function. Takes a die, and converts it to be used for its numerical values.
        /// </summary>
        /// <param name="toParse">takes a die</param>
        /// <returns></returns>
        static List<int> parseDice(string toParse)
        {   
            List<int> nums = new List<int>();

            string[] splitString = toParse.ToLower().Split('d');


            try
            {
                nums.Add(int.Parse(splitString[0]));
                nums.Add(int.Parse(splitString[1]));
                if (nums[0] < 1 || nums[1] < 2)
                {
                    //invalid data
                    return null;
                }

                return nums;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        

    }
}
