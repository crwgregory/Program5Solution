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
            //call all of my integers and varables
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
            int theListChoiceAsInt = 0;
            string guessedWords = "";
            //-------------------------The Lists Of Words-------------------------\\
            string sciFi = "alien android beam blaster cryostasis cyberspace homeworld multiverse posthuman robot spaceship telepathy teleportation";
            string movieTitles = "fury wolves divergent hercules lucy godzilla inception transformers battleship aliens thor avatar glasiator watchmen oblivion";
            //---------------------------------------------------------------------\\

            Console.WriteLine("Hello, welcome to Hang Man. \nPlease enter your name.");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nice to meet you " + name + ", lets start playing!.");
            Thread.Sleep(2000);
            Console.Clear();
            //the main loop of still playing
            while (stillPlaying)
            {
                //a choice of what list the user wants to play with 
                while (choiceOfList)
            {

                Console.WriteLine("There are two lists. One of SciFi Words, and one of Movie Titles. Choose wisely.");
                Console.WriteLine("Enter: 1 for SciFi, or 2 for Movie");
                listChoice = Console.ReadLine();
                if (listChoice.ToString() != "1" && listChoice.ToString() != "2")
                {
                    Console.Clear();
                    Console.WriteLine("\nThat was not a number of 1 or 2, please try again.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else if (listChoice.ToString() == "1")
                {
                    Console.Clear();
                    Console.WriteLine("\nYou choose SciFi, good choice.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    choiceOfList = false;
                    theListChoiceAsInt = int.Parse(listChoice);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nOk, you choose movie titles. Grab the popcorn.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    choiceOfList = false;
                    theListChoiceAsInt = int.Parse(listChoice);
                }
                //uses user input to choose a random word from the list choice
                chosenWord = WordMaker(theListChoiceAsInt, sciFi, movieTitles);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(NewOutput(chosenWord));
            Console.WriteLine();
            //creates a string  that only contains dash's and spaces set to the length of the word chosen. This will be used to see if the user
            //has entered a correct letter
            outputBefore = NewOutput(chosenWord);
            guessedTheWord = false;

           //where the main game is held
                while (!guessedTheWord && guesssLeft > 0)
                {
                    Console.WriteLine("You have " + guesssLeft + " guess's.");
                    Console.WriteLine("Please enter a letter or word you want to guess." + chosenWord);
                    userInput = Console.ReadLine();
                    Console.Clear();
                    if (userInput.Length > 1)
                    {
                        guessedWords = guessedWords + userInput + ", ";
                        Console.WriteLine(GuessedWordsAndLetters(lettersGuessed, guessedWords));
                        Console.WriteLine(LetterGuess(lettersGuessed, chosenWord));
                        //if it is right, asks the user if they want to play again
                        if (userInput == chosenWord)
                        {
                            Console.WriteLine("Nice job!");
                            guessedTheWord = true;
                            break;
                        }
                            //if not correct takes a guess and sees if they have 0 guess left
                        else
                        {
                            guesssLeft--;
                            Console.WriteLine("Sorry that wasn't right");
                            newOutput = LetterGuess(lettersGuessed, chosenWord);
                            if (guesssLeft == 0)
                            {
                                break;
                            }  
                        }
                    }
	                //sees if the input is equal to a single letter 
                    else if (userInput.Length == 1)
                    {
                        lettersGuessed = lettersGuessed + userInput;
                        Console.WriteLine(GuessedWordsAndLetters(lettersGuessed, guessedWords));
                        newOutput = LetterGuess(lettersGuessed, chosenWord);
                        Console.WriteLine(newOutput);
                        //if new output of the letter list is the same as before then it knows it was not a right letter
                        if (outputBefore == newOutput)
                        {
                            Console.WriteLine("Sorry that wasn't correct. Try again.");
                            guesssLeft--;
                            outputBefore = newOutput;
                            if (guesssLeft == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("You ran out of Guess's. The word was: " + chosenWord);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nice job!");
                            outputBefore = newOutput;
                            if (newOutput == chosenWord)
                            {
                                Console.WriteLine();
                                guessedTheWord = true;
                                break;
                            }
                        }                       
                    }
                    else
                    {
                        Console.WriteLine(GuessedWordsAndLetters(lettersGuessed, guessedWords));
                        Console.WriteLine(LetterGuess(lettersGuessed, chosenWord));
                        Console.WriteLine("Please enter a letter or a word guess");
                    }
                }
                //asks the user if they want to play again
                bool doesntWantToContinue = false;
                while (!doesntWantToContinue)
                {
                    Console.WriteLine("Do you want to play again? 'Yes' or 'No'");
                    wantsToPlayAgain = Console.ReadLine();
                    Console.Clear();
                    if (wantsToPlayAgain.ToLower() == "no")
                    {
                        doesntWantToContinue = true;
                        stillPlaying = false;
                        guessedTheWord = true;
                        break;
                    }

                    else if (wantsToPlayAgain.ToLower() == "yes")
                    {
                        guesssLeft = 7;
                        newOutput = NewOutput(chosenWord);
                        lettersGuessed = "";
                        Console.Clear();
                        //Console.WriteLine();
                        //Console.WriteLine();
                        guessedTheWord = true;
                        listChoice = "";
                        choiceOfList = true;
                        guessedWords = "";
                        //only to exit this loop to start the game over
                        doesntWantToContinue = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'yes', or 'no'.");
                        doesntWantToContinue = false;
                    } 
                }
                
                
            }
            Console.WriteLine("Thanks for playing! Come back soon. (Press enter to exit)");

        }

        static string PrintOutList(string list1, string list2)
        {
            string userInput = string.Empty;
            
            Console.WriteLine("Would you like to see what is in a list list?");
            userInput = Console.ReadLine().ToLower();
            
            if (userInput == "yes")
            {
                Console.Clear();
                Console.WriteLine("What list would you like to see? \n1 or 2.");
                userInput = Console.ReadLine();

                if (true)
	            {
		            //what list to print out? does not need to make two lists
                            List<string> List1 = new List<string>(list1.Split());
                            List<string> List2 = new List<string>(list2.Split());
                            Console.Clear();
                            Console.WriteLine(string.Join(", ", list)) 
	            }
            }
        }


        /// <summary>
        /// prints out your guesses
        /// </summary>
        /// <param name="letters">Guessed Letters</param>
        /// <param name="words">Guessed Words</param>
        /// <returns></returns>
        static string GuessedWordsAndLetters(string letters, string words)
        {
            string guessedLetters = letters;
            string guessedWords = words;
            if (guessedWords.Length > 0 && guessedLetters.Length > 0)
            {
                return "Guessed letters: " + guessedLetters + "\nGuessed words: " + guessedWords + "\n";
            }
            else if (guessedLetters.Length > 0)
            {
                return "Guessed letters: " + guessedLetters + "\n\n";
            }
            else if (guessedWords.Length > 0)
            {
                return "\nGuessed words: " + guessedWords +"\n";
            }
            else
            {
                return "\n\n";
            }
        }

        /// <summary>
        /// prints out dash's and spaces equal to the chosen word
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        /// <summary>
        /// out puts a string that sees if the choosen letter is equal to whats in the word
        /// </summary>
        /// <param name="input">chosen letters list</param>
        /// <param name="word">the chosen word</param>
        /// <returns></returns>
        static string LetterGuess(string input, string word)
        {
            //change code so it doesn't get new word everytime
            string userGussedLetters = input.ToLower();
            string output = "";
            string wordInPlay = word;
            
            //this needs to work correctly
            for (int i = 0; i < wordInPlay.Length; i++)
            {
                

                    

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
        /// <summary>
        /// gets a random word form a list letting the user choose which list to use
        /// </summary>
        /// <param name="input">the int that selects the list</param>
        /// <returns></returns>
        static string WordMaker(int input, string list1, string list2)
        {
            Random rng = new Random();
            string sciFi = list1;
            string action = list2;

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
