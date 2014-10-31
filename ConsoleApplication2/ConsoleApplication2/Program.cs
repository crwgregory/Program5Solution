using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num < 11)
            {
                //Console.WriteLine(num);
                num = num + 1;
            }

            letterCounter("The big red dog", "e");
            numberOfWordFinder("yada yada blah blah see you there in the sana", "yada");

            Console.ReadKey();
        }


        static void numberOfWordFinder(string document, string word)
        {
            int NumberOfWords = 0;
            string[] myArray = document.Split(' ');
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == word)
                {
                    NumberOfWords += 1;
                }
            }
            Console.WriteLine(document + " has " + NumberOfWords + " instences of " + word);

        }


        /// <summary>
        /// Letter counter
        /// </summary>
        /// <param name="TheString"></param>
        /// <param name="LetterBeingCounted"></param>
        static void letterCounter(string TheString, string LetterBeingCounted)
        {
            int TotalNumberOfLetters = 0;
            for (int i = 0; i < TheString.Length; i++)
            {
                if (TheString[i].ToString().ToLower() == LetterBeingCounted.ToLower()) 
                {
                    TotalNumberOfLetters += 1;
                }
            }
            Console.WriteLine("String " + TheString + " has " + TotalNumberOfLetters + " instences of letter " + LetterBeingCounted);
        }

        
            
        /// <summary>
        /// FizzBuzz Mafaka
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        static void fizzBuzz(int num1, int num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (i % 5 == 0)
	            {
		            Console.WriteLine("Buzz");
	            }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
