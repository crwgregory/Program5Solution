using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DisemvowelerChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);


            //Disemvoweller("Nickleback is my favorite band. Their songwriting can't be beat!", "aeiou");
            //Disemvoweller("How many bears could bear grylls grill if bear grylls could grill bears?", "aeiou");
            //Disemvoweller("I'm a code ninja, baby. I make the functions and I make the calls.", "aeiou");

            Console.ReadKey();
        }


        /// <summary>
        /// Takes an amount of money (5.55 five dollars and fifty five cents) and prints out how much that would be if u changed it. So using 
        /// quarters then dimes then nickels and finally pinnies
        /// </summary>
        /// <param name="amount">amount you want to make change for</param>
        static void ChangeMaker(double amount)
        {
            //conters for the change, will add each time you can use each coin
            int quarters = 0;
            int dimes = 0;
            int nickles = 0;
            int pennies = 0;

            double totalAmount = amount;
            
            //loops through the amount givin and finds how many times the coin can go into it,
            //once a coin is found it adds one to the total amount of times that coin has been used 
            //then minus's that amount from the total and runs the loop again with the new amount.
            while (totalAmount > 0)
            {
                if (totalAmount >= .25)
                {
                    quarters++;
                    totalAmount = totalAmount - .25;
                }
                else if (totalAmount >= .1)
                {
                    dimes++;
                    totalAmount = totalAmount - .1;
                }
                else if (totalAmount >= .05)
                {
                    nickles++;
                    totalAmount = totalAmount - .05;
                }
                else
                {
                    pennies++;
                    totalAmount = totalAmount - .01;
                }
            }

            //prints results to console.
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Quarters: " + quarters);
            Console.WriteLine("Dimes: " + dimes);
            Console.WriteLine("Nickels: " + nickles);
            Console.WriteLine("Pennies: " + pennies);
            Console.WriteLine();
        }


        /// <summary>
        /// Takes a string of imput no matter the length, and the words to take out of the string. If a user wish's to omit letters besides the vowels, the output can simply
        /// be changed to accomodate this.
        /// </summary>
        /// <param name="input">the string to be worked upon</param>
        /// <param name="omited">the letters to be removed from the string</param>
        static void Disemvoweller(string input, string omited)
        {
            //create my lists and set a bool value to be used in a later for loop.
            var Disemvowelled = new List<char>();
            var theVowels = new List<char>();
            var omit = new List<string>();
            bool myBool = true;
            //populate omit list
            for (int i = 0; i < omited.Length; i++)
			{
			    omit.Add(omited[i].ToString().ToLower());
			}

            //tests the omit list
            //omit.ForEach(Console.Write);

            //loop through string to find index's within the string
            for (int i = 0; i < input.Length; i++)
            {
                myBool = true;
                //a loop to check all letters to be omitted against the letter in the string being checked.
                foreach (string Char in omit)
                {
                    if (Char == input[i].ToString().ToLower())
                    {
                        //if it is a vowel or letter to be omitted it is added to the list
                        theVowels.Add(input[i]);
                        //sets the bool to false so as not to run the rest of the code and breaks the foreach loop to stop it checking 'i' against any other letters.
                        myBool = false;
                        break;
                    }
                }
                if (myBool)
                {
                    //checks to see if 'i' is a space
                    if (input[i].ToString() == " ")
                    {
                        //disregards the space
                        
                    }
                    //if nothing else the program counts it as a consonant, and add it to the appropate list.
                    else
                    {
                        Disemvowelled.Add(input[i]);
                        
                    }
                }
            }
           
            
            //output
            Thread.Sleep(600);
            Console.WriteLine("Heres what you gave me to work with: ");
            Thread.Sleep(600);

            slowTyper(input);
            Console.WriteLine();
            Thread.Sleep(300);
            Console.WriteLine();

            slowTyper("I am now going to take all the letters out of it that you didn't like! '" + omited + "'");
            Console.WriteLine();
            slowTyper(theVowels);
            Console.WriteLine();
            Console.WriteLine();

            
            Console.Write("Heres whats leftover.");
            Console.WriteLine();
            slowTyper(Disemvowelled);
            Console.WriteLine();
            Console.WriteLine();
            

        }

        static void slowTyper(string input)
        {
            string[] stringArray = input.Split(' ');
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write(stringArray[i] + " ");
                Thread.Sleep(300);
            }
        }

        static void slowTyper(List<char> input)
        {
            var List = new List<string>();
            
            for (int i = 0; i < input.Count(); i++)
            {
                string x = input[i].ToString();
                List.Add(x);
            }
            foreach (string item in List)
            {
                Console.Write(item);
                Thread.Sleep(300);
            }

        }
    }
}
