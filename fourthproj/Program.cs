using System;
using System.Collections.Generic;

namespace fourthproj
{
    class Program
    {
        public static Random rand = new Random();
        public static int findMax(int[] X)
        {
            int max = X[0];
            if(X.Length > 1)
            {
                for(int i = 1; i < X.Length; i++)
                {
                    if (X[i] > max)
                    {
                        max = X[i];
                    }
                }
            }
            return (max);
        }
        public static int findMin(int[] X)
        {
            int min = X[0];
            if(X.Length > 1)
            {
                for(int i = 1; i < X.Length; i++)
                {
                    if (X[i] < min)
                    {
                        min = X[i];
                    }
                }
            }
            return (min);
        }
        public static float getSum(int[] X)
        {
            float avg = 0;
            int summy = 0;
            foreach (int item in X)
            {
                summy += item;
            }
            avg = (float)summy/(float)X.Length;
            return (avg);
        }
        public static void MMS(int[] X)
        {
            float sum = getSum(X);
            int maximus = findMax(X);
            int minimus = findMin(X);
            System.Console.WriteLine("Max:{0}, Min:{1}, Sum:{2}", maximus, minimus, sum);
        }

       //Random Array returns integer array of length 10 with values between 5-25. print min and max values and sum
        public static int[] RandomArray(int length = 10)
        {
            int[] arr= new int[10];
            for(int i = 0; i< arr.Length; i++)
            {
                arr[i] = rand.Next(5,25);
            }
            return arr;
        }
        //Coin Flip - Create a function called TossCoin that returns a string. print "Tossing a Coin!!" Randomize toss with result either heads or tails. return the result
        public static int TossCoin()
        {
            System.Console.WriteLine("Tossing a Coin");
            int toss = rand.Next(0,2);
            if(toss == 0)
            {
                System.Console.WriteLine("Tails!");
            }
            else
            {
                System.Console.WriteLine("Heads!");
            }
            return toss;
        }
        //Toss MultipleCoins(int num) returns a Double. Return a double reflecting the ratio of head toss to total toss
        public static double MultipleCoins(int num)
        {
            int sum = 0;
            int count = 0;
            for(int i = 1; i <= num; i++)
            {
                sum += TossCoin();
                count ++;
            }

            float ratio = (float) sum / (float) count;
            double result = (double) ratio;
            return result;
        }
        //Names - returns array of strings. Create an array with values Todd, Tiffany, Charlie, Geneva, Sydney. Shuffle the array and print the values in the new order.
        public static string[] Names(string[] arr)
        {
            for (int t = 0; t < arr.Length; t++ )
            {
                string tmp = arr[t];
                int r = rand.Next(t, arr.Length);
                arr[t] = arr[r];
                arr[r] = tmp;
            }
            return arr;
        }
        public static void printArr(string[] arr)
        {
            foreach(string item in arr)
            {
                Console.WriteLine(item);
            }
        }
        // Return an array that only includes names longer than 5 characters
        public static string[] trimArr(string[] arr)
        {
            List<string> newer = new List<string>();
            int count = 0;
            foreach(string item in arr)
            {
                if (item.Length >=5)
                {
                    newer.Add(item);
                    count ++;
                }
            }
            string[] result = new string[count];
            for(int i = 0; i < count; i++)
            {
                result[i] = newer[i];

            }
            return result;
        }
        public static void Main(string[] args)
        {
            int[] X = RandomArray();
            MMS(X);
            System.Console.WriteLine(MultipleCoins(5));
            string[] arr = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            printArr(Names(arr));
            printArr(trimArr(arr));
        }
    }
}
