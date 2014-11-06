using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week_Of_November_3rd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            textPrinter("yogabagaba", 1000);

            Console.ReadKey();
        }

        static void textPrinter(string inputString, int time)
        {
            var theList = new List<string>();
            for (int i = 0; i < inputString.Length; i++)
            {
                theList.Add(inputString[i].ToString());
            }
            //create a function with the console . write and the sleep method within it
            foreach (string x in theList)
            {
                Console.Write(x);
                Thread.Sleep(time);
            }
        }

        static void SringBuilderExample()
        {
            StringBuilder aStringBuilder = new StringBuilder();
            //aStringBuilder.
        }



    }
}
