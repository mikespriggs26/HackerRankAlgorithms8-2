using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgorithms8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 352926151; //# of prisoners
            int m = 380324688; //# of treats
            int s = 94730870; //the first chair

            int j = m % n;
            int finalChair = s - 1 + j;
            


            //int finalChair = (s - 1 + m) % n;
            //if(finalChair == 0)
            //{
            //    finalChair = s;
            //}

            Console.WriteLine(finalChair);

            Console.ReadLine();

        }
    }
}
