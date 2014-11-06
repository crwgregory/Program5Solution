using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            textCounter("Hello Jennifer! I'm Chris!");
            Console.ReadKey();
        }

        static void textCounter(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
