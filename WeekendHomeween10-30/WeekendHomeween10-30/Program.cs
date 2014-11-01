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

            //Yodaizer("People tell me to slow my roll. I'm skreaming out fk that!");
            //Yodaizer3000("you are good");

            TextStats("You've given me more than I can return!");

            Console.ReadKey();
        }

        static void TextStats(string input)
        {
            string[] stringArray = input.Split(' ');
            char[] vowel = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            int numberOfVowels = 0;
            string vowels = "aeiou";
            //prints # of char's
            Console.WriteLine("There are " + input.Length + " characters in this string!");
            Console.WriteLine("There are " + stringArray.Length + " words in this string! You lucky dog you.");
            
            
            for (int i = 0; i < input.Length; i++)
            {
                string theVowel = stringArray[i];
                if ()
                {
                    numberOfVowels++;
                }
                
            }
            Console.WriteLine(numberOfVowels);
        }

        /// <summary>
        /// If the sentence has 3 words it will become words to live by.
        /// </summary>
        /// <param name="text">sentence</param>
        static void Yodaizer3000(string text)
        {
            string[] stringArray = text.Split(' ');

            if (stringArray.Length == 3)
            {
                Console.WriteLine(stringArray[2] + ", " + stringArray[0] + " " + stringArray[1]);
            }
        }

        /// <summary>
        /// The orginal trademark yodaizer
        /// </summary>
        /// <param name="text">say somethin</param>
        static void Yodaizer(string text)
        {
            string[] stringArray = text.Split(' ');
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(stringArray[i]);
            }
        }


        /// <summary>
        /// The infamus fizzbuzz program
        /// </summary>
        /// <param name="num1">first number entered by user</param>
        /// <param name="num2">second number entered by user</param>
        static void FizzBuzz(int number)
        {
            
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
