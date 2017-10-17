using System;
using System.Collections.Generic;

namespace secondproj
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            // Three basic arrays
            // 1. create an array to hold integer values 0 through 9
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            // 2. create an array of the names "Time", "Martin", "Nikki", & "Sara"
            string[] nameArray = {"Tim", "Martin", "Nikki", "Sara"};
            // 3. Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArray = new bool[10];
            for (int idx= 0; idx < boolArray.Length; idx++)
            {
                if(idx % 2 == 0){
                    boolArray[idx] = true;
                }
                Console.WriteLine(boolArray[idx]);
            }
            // Console.WriteLine(boolArray);
                // This gives an output of: System.Boolean[]
            
            // Multiplication Table
            // with the values 1 - 10 create a multiplication table (ten arrays of length 10) - multi-dimensional array
            int[,] timesTable = new int[10,10];
            // Console.WriteLine(timesTable.Length);
            // Result: 100
            for(int i = 0; i<10; i++){
                for(int j = 0; j<10; j++)
                {
                    if (i==0)
                    {
                        timesTable[i,j] = i + 1;
                    }
                    else if (j == 0)
                    {
                        timesTable[i,j] = i + 1;
                    }
                    else
                    {
                        timesTable[i,j] = (i+1) * (j+1);
                    }
                }
            }
            Console.WriteLine(timesTable[9,9]);
            // List of flavors
            // create a list of Ice Cream falvors that holds at least 5 different flavors
            List<string> flavors = new List<string>();
            flavors.Add("vanilla");
            flavors.Add("chocolate");
            flavors.Add("rocky road");
            flavors.Add("strawberry");
            flavors.Add("coffee!!!");
            // outputh length of list after build
            Console.WriteLine(flavors.Count);
            // output third flavor then remove it
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            // output new list length
            Console.WriteLine(flavors.Count);
            // User Info Dictionary
            // Create a Dicsionary that will store both string keys as well as string values
            Dictionary<string,string> userInfo = new Dictionary<string,string>();
            // previous array of names become keys
            foreach(string word in nameArray)
            {
                // for each of those key, select a **random** flavor to set as value
                int temp = rand.Next(0,flavors.Count);
                userInfo.Add(word, flavors[temp]);
            }
            // loop through dictionary and print user name and flavor
            foreach(KeyValuePair<string,string> entry in userInfo)
            {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }
        }
    }
}
