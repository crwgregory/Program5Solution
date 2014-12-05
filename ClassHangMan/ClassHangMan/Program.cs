using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            HangMan();
            Console.ReadKey();
        }

        static void HangMan()
        {
            //declares variables
            int numberOfGuesesLeft = 7;
            List<string> wordBank = new List<string>() { "carrot", "awesome" };
            Random rng = new Random();
            string wordToGuess = wordBank[rng.Next(0, wordBank.Count())];
            string lettersGuessed = string.Empty;
            bool playing = true;

            while (playing)
            {
                DisplayRoundInfo(lettersGuessed, wordToGuess, numberOfGuesesLeft);
                string input = GetUserInput(lettersGuessed);
                if (input.Length == 1)
                {
                    //its a letter guess, add it to the letters guessed
                    lettersGuessed += input;
                    if (wordToGuess.ToLower().Contains(input.ToLower()))
                    {
                        //its a correct guess
                        if (!GetMaskedWord(lettersGuessed, wordToGuess).Contains("_"))
                        {
                            //way to go you won
                            playing = false;
                        }
                    }
                    else
                    {
                        //incorrect guess, subtract the guess
                        numberOfGuesesLeft--;
                        playing = (numberOfGuesesLeft > 0);
                    }
                }
                else
                {
                    //its a word
                    if (input.ToLower() == wordToGuess.ToLower())
                    {
                        //its a match
                        playing = false;
                    }
                    else
                    {
                        //word guess is false
                        numberOfGuesesLeft--;
                        playing = (numberOfGuesesLeft > 0);
                    }
                }
            }
            //game ended decide if they won or lost
            if (numberOfGuesesLeft > 0)
            {
                Console.WriteLine(wordToGuess);
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("Your bad at life and also this game");
            }
        }

        static string GetUserInput(string lettersGuessed)
        {
            //declare var to hold input
            string returnString;
            bool isValid = true;
            do
            {
                returnString = Console.ReadLine();
                if (returnString.Length == 0)
                {
                    isValid = false;
                }
                else if (returnString.Length == 1)
                {
                    if (char.IsLetter(returnString[0]))
                    {
                        isValid = true;
                        if (isValid)
                        {
                            //make sure letter hasn't been guessed
                            isValid = !lettersGuessed.ToLower().Contains(returnString.ToLower());
                        }
                    }
                }

            } while (isValid == false);
            //return return string
            return returnString;
            

        }


        static void DisplayRoundInfo(string lettersGuessed, string wordGuessed, int guesesLeft)
        {
            //before we right anything, just clear the console.
            Console.Clear();
            Console.WriteLine(GetMaskedWord(lettersGuessed, wordGuessed));
            Console.WriteLine("# of letters guessed " + guesesLeft);
            Console.WriteLine("Letters guessed: " + lettersGuessed.ToUpper());
            Console.WriteLine("Your guess: ");

        }

        static string GetMaskedWord(string lettersGuessed, string wordBeingGuessed)
        {
            string returnString = string.Empty;
            //loop over every letter of the word they need to guess
            for (int i = 0; i < wordBeingGuessed.Length; i++)
            {
                //get the current letter of the word they need to guess
                string currentLetter = wordBeingGuessed[i].ToString().ToLower();
                if (lettersGuessed.ToLower().Contains(currentLetter))
                {
                    returnString += currentLetter + " ";
                }
                else
                {
                    returnString += "_ ";
                }

            }
            return returnString;
        }
    }


}
