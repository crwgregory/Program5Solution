using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendHomeween10_30
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                //FizzBuzz(i);
            }

            for (int i = 92; i > 79; i--)
            {
                //FizzBuzz(i);
            }

            //Yodaizer("People tell me to slow my roll I'm skreaming out fk that");
            //Yodaizer3000("you are good");

            //TextStats("You've given me more than I can return!");

            for (int i = 1; i <= 20; i = i + 2)
            {
                //IsPrime(i);  
            }

            DashInsert(8675309);
            

            Console.ReadKey();
        }

        /// <summary>
        /// inserts dash's between odd numbers
        /// </summary>
        /// <param name="number"></param>
        static void DashInsert(int number)
        {
            
            List<char> listOfNumbersAndDashs = new List<char>();
            List<char> oddOrNotZeroIsEvenOneIsOdd = new List<char>();
            //used for inserting dash's at end of program
            int numberOfDashs = 0;

            //turns input number to a string to count index through
            string stringNumber = number.ToString();
            for (int i = 0; i < stringNumber.Length; i++)
            {
                //creates a list of the string of numbers
                listOfNumbersAndDashs.Add(stringNumber[i]);
                //goes through string seeing if the number is an odd or even
                if (stringNumber[i] % 2 == 0)
                {
                    if (stringNumber[i] == 0)
                    {
                        //do nothing but log a zero to odd or not list showing that 0 is not odd
                        oddOrNotZeroIsEvenOneIsOdd.Add('0');
                    }
                    //checks to see if number is even 
                    //if number is even logs a zero to odd or not list
                    //if it is even it runs for loop again
                    oddOrNotZeroIsEvenOneIsOdd.Add('0');
                }
                else
                {
                    //number is odd 
                    //logs a 1 to odd or not list
                    oddOrNotZeroIsEvenOneIsOdd.Add('1');
                }

                
            }
            //test the odd or not list
                for (int x = 0; x < oddOrNotZeroIsEvenOneIsOdd.Count(); x++)
                {
                    //Console.WriteLine(oddOrNotZeroIsEvenOneIsOdd[x]);
                }

            //checks if there are two odd numbers next to each other
            //index's two places in the same list and sees if they are log'd as 1's(which means they are odd numbers)
           int y = 0;
           for (int x = 1; x < oddOrNotZeroIsEvenOneIsOdd.Count(); x++)
           {
                        
                        
                if (oddOrNotZeroIsEvenOneIsOdd[y] == '1' && oddOrNotZeroIsEvenOneIsOdd[x] == '1')
                {
                    //adds a dash to list of numbers at index of two odd numbers
                    //also checks if there are already dash's to change the index value if there are
                    listOfNumbersAndDashs.Insert(x + numberOfDashs, '-');
                            
                    //need to log number of dash's so we can adjust indexer to add to list as we go
                    numberOfDashs++;
                            
                }
                //needed to increment i value sense we do not go back 
                y++;
                        
           }
                
           //and finally we print the results
           listOfNumbersAndDashs.ForEach(Console.Write);

        }


        /// <summary>
        /// Sees if a number is prime
        /// </summary>
        /// <param name="number"></param>
        static void IsPrime(int number)
        {

            int prime = 0;
            
            //for loop starts at 2 to exlude 1, because all numbers besides 0 are devisable by 1
            //then goes through and sees if any number between the inputed number and 2 can go into the inputed number evenly
            //if it can then it adds a number to the counter 'prime'
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    prime++;
                }
                
            }
            
            //sees if prime is still equal to zero, if it is it means that no number could of gone into the input number.
            //could also use a bool here and set it to false at anytime. doing that it could save memory because u could use a while loop to stop as soon 
            //as a number was found that could go into input number
            if (prime != 0)
            {
                Console.WriteLine(number);

            }
            else
            {
                Console.WriteLine(number + " is a prime number.");
            }

        }


        /// <summary>
        /// gets information partaining to a input string
        /// </summary>
        /// <param name="theString"></param>
        static void TextStats(string input)
        {

            //puts the string to all lower case
            string theString = input.ToLower();
            
            string[] stringArray = theString.Split(' ');
            
            int numberOfVowels = 0;
            int numberOfSpecial = 0;
            int numberOfConsonants = 0;

            
            for (int x = 0; x < theString.Length; x++)
            {
                char i = theString[x];
                //checks for vowels and add a to a counter if it is a vowel, the rest are self explained
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                {
                    numberOfVowels++;
                }
                else if (i == ' ' || i == '.' || i == '!')
                {
                    numberOfSpecial++;
                }
                // any thing left is a consonant, (for this to be 100% true we would have to add in all of the special characters, or 
                    //check for all consonants.
                else
                {
                    numberOfConsonants++;
                }
            }
            //out puts 
            Console.WriteLine("There are " + theString.Length + " characters in this string!");
            Console.WriteLine("There are " + stringArray.Length + " words in this string! You lucky dog you.");
            Console.WriteLine("There are " + numberOfVowels + " vowels in this string.");
            Console.WriteLine("There are " + numberOfConsonants + " consonants in this string.");
            Console.WriteLine("There are " + numberOfSpecial + " special charaters in this string.");
            
        }

        /// <summary>
        /// If the sentence has 3 words it will become words to live by.
        /// </summary>
        /// <param name="text">sentence</param>
        static void Yodaizer3000(string text)
        {
            //makes a string array of the words
            string[] stringArray = text.Split(' ');

            //checks if the sentence is three words long, if it is it changes position of output to what yoda would say
            if (stringArray.Length == 3)
            {
                Console.Write(stringArray[2] + ", " + stringArray[0] + " " + stringArray[1]);
            }
        }

        /// <summary>
        /// The orginal trademark yodaizer
        /// </summary>
        /// <param name="text">say somethin</param>
        static void Yodaizer(string text)
        {
            //creates string array of the words in the input text
            string[] stringArray = text.Split(' ');
            //loops backwords through the array and prints the last word first and so on
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                Console.Write(stringArray[i] + " ");
                
            }
            Console.WriteLine();
        }


        /// <summary>
        /// The infamus fizzbuzz program
        /// </summary>
        /// <param name="num1">first number entered by user</param>
        /// <param name="num2">second number entered by user</param>
        static void FizzBuzz(int number)
        {
            
            //uses loops created in main function to use this equation to complete processes    
            if (number == 0)
                {
                    Console.WriteLine(number); 
                }
                else if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            
        }
    }
}
