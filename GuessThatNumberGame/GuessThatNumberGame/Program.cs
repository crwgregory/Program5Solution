using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {

            guessThatNumber();
            Console.ReadKey();

        }

        static void guessThatNumber()
        {
            Random rng = new Random();
            int guess = 0;
            bool isUserRight = false;
            int numberToGuess = rng.Next(1, 101);
            string userInput = "";

            //checks the bool statement to determine if users imput is right, if its not it runs the code.
            while (!isUserRight)
            {
                //asks user to imput a number
                Console.Write("What number do you choose? " + /*numberToGuess +*/ " ");
                bool myBool = false;
                //runs the imput against a try and sees if the input was valid.
                while (!myBool)
                {
                    
                    
                    try
                    {   
                        userInput = Console.ReadLine();
                        guess = int.Parse(userInput);
                        myBool = true;
                        //if input was valid it logs input and exits the loop to continue running the code
                    }
                    //if input was not valid
                    catch (Exception ex)
                    {
                        Console.WriteLine("YOU SHALL NOT PASS!");
                        Console.WriteLine(ex.Message);
                    } 
                }
                //sees if the input is equal to the random number generated
                if (guess == numberToGuess)
                {
                    isUserRight = true;
                }
                //if user input is not equal to random number generated then it see if the user needs to go higher or lower
                //and logs accordingly
                if (guess < numberToGuess)
                {
                    Console.WriteLine("Your guess is to low!\n");
                }
                if (guess > numberToGuess)
                {
                    Console.WriteLine("Your GUESS is to high!\n");
                }
                //then repeats the process until the user guessed number is equal to the random number generated.
            }
            Console.WriteLine();
            Console.WriteLine("Congrats bro! You guessed the number! Cyberfive!");

        }
    }
}
