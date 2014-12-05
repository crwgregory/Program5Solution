using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //establishing all units of currency
            Coin.InitializeCurrency();
            
            MakeChange(3.18);
            MakeChange(0.99);
            MakeChange(12.93);

            //extra credit
            MakeChange(481.66);

            //keep the program open
            Console.ReadKey();

        }
        static void MakeChange(double dollarsAndCentsToChange)
        {
            //convert dollar and cents value to int for easier use
            double roundedToNearestPenny = Math.Round(dollarsAndCentsToChange, 2);
            int valueInCents = (int)(roundedToNearestPenny * 100);
            Console.WriteLine("You gave me $" + roundedToNearestPenny + ", so here is your change:");

            //create array of counters for each coin and initializes each counter to zero
            int[] coinCount = new int[Coin.USCurrency.Count()];
            for (int i = 0; i < coinCount.Length; i++)
            {
                coinCount[i] = 0;
            }

            //main loop that adds coins to the counter array
            foreach (Coin moneyDenomination in Coin.USCurrency)
            {
                if (valueInCents >= moneyDenomination.valueInPennies)
                {
                    //We can use this coin, so use as many of them as we can
                    int qtyOfThisCoinToGive = valueInCents / moneyDenomination.valueInPennies;

                    //increment our coin counter
                    coinCount[Coin.USCurrency.IndexOf(moneyDenomination)] += qtyOfThisCoinToGive;

                    //subtract out the monetary value that we gave in coins
                    valueInCents -= qtyOfThisCoinToGive * moneyDenomination.valueInPennies;
                }

            }

            for (int i = 0; i < coinCount.Length; i++)
            {
                if (coinCount[i] != 0)
                {
                    //we have given out this coin, so we should talk about it.
                    if (coinCount[i] > 1)
                    {
                        //we gave more than one of them, so we should refer to the plural name
                        Console.WriteLine(coinCount[i] + " " + Coin.USCurrency[i].namePlural);
                    }
                    else
                    {
                        //we only gave out one, so use the singular name
                        Console.WriteLine(coinCount[i] + " " + Coin.USCurrency[i].nameSingular);
                    }
                }
            }
            //puts a blank line between function calls for clarity
            Console.WriteLine();
        }
    }






    //class to handle denominations of money
    class Coin : IComparable
    {
        //declaring variables - fairly self explanatory
        public string nameSingular, namePlural;
        public int valueInPennies;

        //declaring a static list to hold all types of coins
        public static List<Coin> USCurrency = new List<Coin>();

        //declaring a static function to initialize the static coin list
        public static void InitializeCurrency()
        {
            new Coin(1, "Penny", "Pennies");
            new Coin(5, "Nickel");
            new Coin(10, "Dime");
            new Coin(25, "Quarter");
            new Coin(100, "Single");
            new Coin(500, "Five dollar bill");
            new Coin(1000, "Ten dollar bill");
            new Coin(2000, "Twenty dollar bill");
            new Coin(5000, "Fifty dollar bill");
            new Coin(10000, "Hundred dollar bill");
        }

        //adding ToString() override to be able to test initialization
        public override string ToString()
        {
            return nameSingular + " (worth " + valueInPennies + " cents)";
        }

        //constructor
        public Coin(int _value, string _name, string _namePlural = "")
        {
            nameSingular = _name;
            if (_namePlural == "")
            {
                //the user has not given us a unique plural form, so just tack on an 's'.
                namePlural = nameSingular + "s";
            }
            else
            {
                //user has given us a plural form, so let's use it.
                namePlural = _namePlural;
            }
            valueInPennies = _value;

            //Add this new instance to the list of US Currencies and sort it
            USCurrency.Add(this);
            USCurrency.Sort();
        }


        public int CompareTo(object otherCoin)
        {
            //Used to sort the list with higher denominations first
            Coin secondCoin = (Coin)otherCoin;
            if (this.valueInPennies > secondCoin.valueInPennies)
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }
    }
}
