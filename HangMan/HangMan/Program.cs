using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HangMan
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

            int guesssLeft = 7;
            string userInput = "";
            bool stillPlaying = true;
            bool guessedTheWord = false;
            string chosenWord = "";
            string name = "";
            string lettersGuessed = "";
            string outputBefore = "";
            string newOutput = "";
            string wantsToPlayAgain = "";
            string listChoice = "";
            bool choiceOfList = true;

            

            Console.WriteLine("Hello, welcome to Hang Man. \nPlease enter your name.");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nice to meet you " + name + ", lets start playing!.");
             while (stillPlaying)
            {
                 while (choiceOfList)
            {

                Console.WriteLine("There are two lists. One of SciFi Words, and one of Movie Titles. Choose wisely.");
                Console.WriteLine("Enter; 1 for SciFi, or 2 for Movie");
                listChoice = Console.ReadLine();
                int theListChoiceAsInt = int.Parse(listChoice);
                if (theListChoiceAsInt != 1 && theListChoiceAsInt != 2)
                {
                    Console.Clear();
                    Console.WriteLine("That was not a number of 1 or 2, please try again.");
                    Thread.Sleep(5000);
                    Console.Clear();
                    
                }
                else if (theListChoiceAsInt == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You choose SciFi, good choice.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    choiceOfList = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ok, you choose movie titles. Grab the popcorn.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    choiceOfList = false;
                }
                chosenWord = WordMaker(theListChoiceAsInt);

            }

            Console.WriteLine();
            Console.WriteLine(NewOutput(chosenWord));

           
                while (!guessedTheWord && guesssLeft > 0)
                {
                    //Console.WriteLine(newOutput);
                    Console.WriteLine("You have " + guesssLeft + " guess's.");

                    Console.WriteLine("Please enter a letter or word you want to guess.");
                    userInput = Console.ReadLine();
                    Console.Clear();
                    
                    lettersGuessed = lettersGuessed + userInput;
                    Console.WriteLine("Letters guessed: " + lettersGuessed);
                    if (userInput.Length > 1)
                    {
                        
                        if (userInput == chosenWord)
                        {
                            Console.WriteLine("You win!");
                            guessedTheWord = true;
                            Console.WriteLine("Do you want to play again? 'Yes' or 'No'");
                            wantsToPlayAgain = Console.ReadLine();
                            if (wantsToPlayAgain.ToLower() == "no")
                            {
                                stillPlaying = false;
                            }
                            else if (wantsToPlayAgain.ToLower() == "yes")
                            {
                                guessedTheWord = false;
                                guesssLeft = 7;
                            }

                            break;
                        }
                        else
                        {
                            guesssLeft--;
                            Console.WriteLine();
                            Console.WriteLine(newOutput);
                            Console.WriteLine("Sorry that wasn't right");
                            if (guesssLeft == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("You ran out of Guess's. The word was: " + chosenWord);
                                Console.WriteLine("Do you want to play again? 'Yes' or 'No'");
                                wantsToPlayAgain = Console.ReadLine();
                                if (wantsToPlayAgain.ToLower() == "no")
                                {

                                    stillPlaying = false;
                                }
                                else if (wantsToPlayAgain.ToLower() == "yes")
                                {
                                    guessedTheWord = false;
                                    guesssLeft = 7;
                                    newOutput = NewOutput(chosenWord);
                                    lettersGuessed = "";
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine(NewOutput(chosenWord));
                                    Console.WriteLine();

                                }
                            }
                            
                        }
                    }
                
	
                    else if (userInput.Length == 1)
                    {

                        outputBefore = newOutput;
                        newOutput = LetterGuess(lettersGuessed, chosenWord);
                        Console.WriteLine();
                        Console.WriteLine(newOutput);
                        if (outputBefore == newOutput)
                        {
                            Console.WriteLine("Sorry that wasn't correct. Try again.");
                            guesssLeft--;
                            if (guesssLeft == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("You ran out of Guess's. The word was: " + chosenWord);
                                Console.WriteLine("Do you want to play again? 'Yes' or 'No'");
                                wantsToPlayAgain = Console.ReadLine();
                                if (wantsToPlayAgain.ToLower() == "no")
                                {

                                    stillPlaying = false;
                                }
                                else if (wantsToPlayAgain.ToLower() == "yes")
                                {
                                    guessedTheWord = false;
                                    guesssLeft = 7;
                                    outputBefore = NewOutput(chosenWord);
                                    lettersGuessed = "";
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine(outputBefore);
                                    Console.WriteLine();
                                    break;
                                    
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nice job!");
                            if (newOutput == chosenWord)
                            {
                                
                                Console.WriteLine();
                                guessedTheWord = true;
                                Console.WriteLine("Do you want to play again? 'Yes' or 'No'");
                                wantsToPlayAgain = Console.ReadLine();
                                if (wantsToPlayAgain.ToLower() == "no")
                                {

                                    stillPlaying = false;
                                }
                                else if (wantsToPlayAgain.ToLower() == "yes")
                                {
                                    guessedTheWord = false;
                                    guesssLeft = 7;
                                    newOutput = NewOutput(chosenWord);
                                    lettersGuessed = "";
                                    Console.Clear();
                                    Console.WriteLine();
                                    //Console.WriteLine(NewOutput(chosenWord));
                                    Console.WriteLine();
                                }

                                
                                break;
                            }
                        }                       
                    }
                    else
                    {
                        //does nothing because...
                    }
                    
                
                }
                
                
            }
            Console.WriteLine("Thanks for playing! Come back soon. (Press enter to exit)");

        }

        static string NewOutput(string input)
        {
            string choosenWord = input;
            string newOutput = "";
            for (int i = 0; i < choosenWord.Length; i++)
            {
                newOutput = newOutput + "_ ";
            }
            return newOutput;
        }

        static string LetterGuess(string input, string word)
        {
            //change code so it doesn't get new word everytime
            string userGussedLetters = input;
            string output = "";
            string wordInPlay = word;
            
            //this needs to work correctly
            for (int i = 0; i < wordInPlay.Length; i++)
            {
                

                    //
                    if (userGussedLetters.Contains(wordInPlay[i]))
                    {
                        output = output + wordInPlay[i];
                        
                    }
                    else
                    {
                        output = output + "_ ";
                        
                    }
                }
            
            return output;
        }

        static string WordMaker(int input)
        {
            Random rng = new Random();
            string sciFi = "alien android beam blaster cryostasis cyberspace homeworld multiverse posthuman robot spaceship telepathy teleportation";
            string action = "fury wolves divergent hercules lucy godzilla inception transformers battleship aliens thor avatar glasiator watchmen oblivion";

            List<string> words = new List<string>();

            if (input == 1)
            {
                words = sciFi.Split(' ').ToList();
            }
            else
            {
                words = action.Split(' ').ToList();
            }

            int indexer = rng.Next(0, words.Count());

            string theWord = words[indexer];
            return theWord;

        }
    }
}
