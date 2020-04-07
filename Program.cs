using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {

//Place 10 random integer values between 5-25 into the array
// Print the min and max values of the array
// Print the sum of all the values
        static void RandomArray()
        {
            int[] Array = new int [10];
            Random rand = new Random();
            int max = 5;
            int min = 25;
            int sum = 0;
            foreach (int i in Array)
            {
                Array[i] = rand.Next(5, 25);
                Console.Write(Array[i] + ", ");
                if (Array[i] > max)
                {
                    max = Array[i];
                }
                if (Array[i] < min)
                {
                    min = Array[i];
                }
                sum += Array[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(max);
            Console.WriteLine(min);

        }

// Have the function print "Tossing a Coin!"
// Randomize a coin toss with a result signaling either side of the coin 
// Have the function print either "Heads" or "Tails"
// Finally, return the result
        public static string  CoinToss()
        {
            Random toss = new Random();
            int coin = toss.Next(0, 200);
            string SVar = "";
            if (coin < 100)
            {
                SVar = "Heads!";
            }
            if (coin >= 100)
            {
                SVar = "Tails!";
            }
            return SVar;
        }


// Have the function call the tossCoin function multiple times based on num value
// Have the function return a Double that reflects the ratio of head toss to total toss
        public static double TossMultipleCoins(int num)
        {
            int HeadCount = 0;
            for (int i = 0; i < num; i++)
            {
                string Head = CoinToss();
                if(Head == "Heads!")
                {
                    HeadCount += 1;
                }
            }
            double Percent = (double)HeadCount / num;
            return Percent;
        }


// Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
// Shuffle the list and print the values in the new order
// Return a list that only includes names longer than 5 characters
        public static List<string> Names()
        {
            List<string> LNames = new List<string>();
            LNames.Add("Todd");
            LNames.Add("Tiffany");
            LNames.Add("Charlie");
            LNames.Add("Geneva");
            LNames.Add("Sydney");

            Random rand = new Random();
            int N = LNames.Count;
            for(int i = 0; i < N; i++)
            {
                int idx = rand.Next(N);
                string temp = LNames[idx];
                LNames[idx] = LNames[i];
                LNames[i] = temp;
            }
            LNames.ForEach(Console.WriteLine);
            for(int k = 0; k < LNames.Count; k++)
            {
                if (LNames[k].Length < 5)
                {
                    LNames.RemoveAt(k);
                }
            }
            return LNames;
        }

        static void Main(string[] args)
        {
            RandomArray();
            Console.WriteLine(CoinToss());
            Console.WriteLine($"Out of the coins you tossed {(TossMultipleCoins(22) * 100)}% of them returned heads");
            Console.Write(Names());

        }
    }
}
