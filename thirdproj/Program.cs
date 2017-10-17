using System;
using System.Collections;

namespace thirdproj
{
    //Basic Thirteen
    class Program
    {
        //1. Print 1-255 (inclusive)
        public static void NoOne()
        {
            for(int i = 1; i<=255; i++)
            {
                Console.WriteLine(i);
            }
        }
        //2. Print odds 1-255 (inclusive)
        public static void NoTwo()
        {
            for(int i=1; i<=255; i+=2)
            {
                Console.WriteLine(i);
            }
        }
        //3. Print Sum to 255
        public static void PrintSum()
        {
            int sum = 0;
            for(int i = 0; i<=255; i++)
            {
                sum += i;
                Console.WriteLine("Number: {0} - Sum: {1}", i, sum);
            }
        }
        //4. Given array X = [1,3,5,7,9,13] print each value
        public static void iterArray(Array X){
            foreach( int item in X)
            {
                Console.WriteLine(item);
            }
        }
        //5. Find Max from array
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
        //6. Get average from array
        public static float getAvg(int[] X)
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
        //7. Array with Odd Numbers Array Y contains all odd numbers from 1 to 255
        public static void Odity()
        {
            int[] Y = new int[255/2 + 1];
            int temp = 1;
            for(int i = 0; i < Y.Length; i++)
            {
                Y[i] = temp;
                temp += 2;
            }
        }
        // public static void Oddity()
        // {
        //     List<int> oddities = new List<int>();
        //     for(int i = 1; i <=255; i +=2)
        //     {
        //         oddities.
        //     }

        // }
        //8. Greater than Y: total number of values in array that are geater than Y
        public static int greaterthan(int Y, Array X)
        {
            int count = 0;
            foreach (int item in X)
            {
                if (item > Y)
                {
                    count ++;
                }
            }
            return count;
        }
        //9. Square the values in an array, in place
        public static void squareArray(int[] X)
        {
            for(int i = 0; i < X.Length; i++)
            {
                X[i] = X[i] * X[i];
                Console.WriteLine(X[i]);
            }
        } 
        //10. Eliminate Negative numbers (replace with 0)
        public static void noNegs(int[] X){
            for(int i = 0; i<X.Length; i++)
            {
                if (X[i] < 0)
                {
                    X[i] = 0;
                }
                Console.WriteLine(X[i]);
            }
        }
        //11. Min, Max and Average
        public static void MMA(int[] X)
        {
            float avg = getAvg(X);
            int maximus = findMax(X);
            int minimus = X[0];
            for(int i =1; i<X.Length; i++)
            {
                if (X[i]<minimus)
                {
                    minimus = X[i];
                }
            }
            System.Console.WriteLine("Max:{0}, Min:{1}, Average:{2}", maximus, minimus, avg);
        }
        //12. Shift values in array, remove first and add 0 to end
        public static void shifty(int[] X)
        {
            for(int i = 0; i<X.Length-1; i++)
            {
                X[i] = X[i+1];
            }
            X[X.Length-1] = 0;
        }
        //13. Number to string, replace negative numbers in array with "Dojo"
        public static void magic(object[] X)
        {
            for(int i = 0; i<X.Length; i++)
            {
                int temp = (int)X[i];
                if (temp < 0)
                {
                    X[i] = "dojo";
                }
                System.Console.WriteLine(X[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] X = {1,3,5,7,9,13};
            int[] Y = {1,-3, 5, -27, 111};
            object[] XX = {1,3,5,7,9,13};
            object[] XY = {1,-3, 5, -27, 111};
            //Call 1:
            // NoOne();
            //Call 2:
            // NoTwo();
            //Call 3:
            // PrintSum();
            //Call 4:
            // iterArray(X);
            //Call 5:
            // Console.Write(findMax(X));
            //Call 6:
            // Console.WriteLine(getAvg(X));
            //Call 7:
            // Odity();
            //Call 8:
            // Console.WriteLine(greaterthan(4, X));
            //Call 9:
            // squareArray(X);
            //Call 10:
            // noNegs(Y);
            //Call 11:
            // MMA(Y);
            //Call 12:
            // shifty(X);
            //Test 12:
            // iterArray(X);
            //Call 13:
            // magic(XY);
        }
    }
}
