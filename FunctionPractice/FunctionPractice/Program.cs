using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            int myAgeDoubled = DoubleIt(23);
            Console.WriteLine(DoubleIt(myAgeDoubled));

            //LoopTest();

            VowelCounter3000Tests(); 

            Console.ReadKey();
        }
       
        /// <summary>
        /// Write Hello World to the Console
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static int DoubleIt(int someNumber)
        {
            return someNumber * 2;
        }
        /// <summary>
        /// prints numbers to console from start to end
        /// </summary>
        /// <param name="startNumber">number loop starts at</param>
        /// <param name="endNumber">number loop ends at</param>

        {
            for (int i = startNumber; i <= endNumber; i = i + 1)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Runs a series of tests on 
        /// our LoopSomeNumbers Function
        /// </summary>
        static void LoopTest()
        {
            LoopSomeNumbers(5, 10);
         
        }
        /// <summary>
        /// Returns # of vowels in string
        /// </summary>
        /// <param name="inputString">A string that you want to count # of vowels</param>
        /// <returns>Number of vowels found</returns>
        static int VowelCounter3000(string inputString)
        {
            //declare counter for vowels
            int numberOfVowelsFound = 0;

            //loop of each letter of the string
            for (int i = 0; i < inputString.Length; i = i +1)
            {
                //takes letter from string and converts it to Lower Case
                string letter = inputString[i].ToString().ToLower();

                //if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                //{
                    //found a vowel
                    //numberOfVowelsFound = numberOfVowelsFound + 1;

                //}

                //alternate way of checking to see if it's 
                //a vowel
                if ("aeiou".Contains(letter))
                {
                    numberOfVowelsFound += 1;
                }
            }

            //loop complete, time to write the output
            Console.WriteLine(inputString + " has " + numberOfVowelsFound + " vowels in it.");
            return numberOfVowelsFound;
        }

        static void VowelCounter3000Tests()
        {
            //count the number of vowels counted
            int totalNumberOfVowelsCounted = 0;
            totalNumberOfVowelsCounted += VowelCounter3000("Jackie seems like a guy who likes nickle back");
            totalNumberOfVowelsCounted += VowelCounter3000("I love eating sushi");
            Console.WriteLine("Total number of vowels counted: " + totalNumberOfVowelsCounted);
        }
    }
}
