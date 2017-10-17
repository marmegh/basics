using System;

namespace puzzlingjack
{
    class Program
    {
        public static string[] MaxPath(int[,] box, string[] pathy, int summy = 0, int R=0, int D=0)
        {
            if (summy == 617)
            {
                return pathy;
            }
            else
            {
                summy += box[D,R];
                if(R<=9)
                {
                    pathy[D+R] = "R";
                    MaxPath(box, pathy, summy, R++, D);
                }
                if(D<=8)
                {
                    pathy[D+R] = "D";
                    MaxPath(box, pathy, summy, R, D++);
                }
                summy-=box[D,R];
            }
        }
        static void Main(string[] args)
        {
            int[,] X=  {{4,25,33,47,5,33,38,41,48,42},{39,25,29,24,26,2,47,16,25,32},{21,7,2,45,48,48,16,16,48,4},{30,35,8,29,2,16,6,43,40,39},{42,42,46,30,30,7,19,41,49,25},{35,45,10,24,33,43,46,16,22,6},{46,29,2,42,48,44,28,28,48,35},{28,33,6,46,28,25,42,14,34,32},{23,14,18,16,12,9,36,33,37,29}};
            string[] pathy= {"","","","","","","","","","","","","","","","",""};
            MaxPath(X,pathy);
        }
    }
}
