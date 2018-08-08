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
            //**********Find Digits
            int n = 1012;

            //for
            int left = n;
            int rev = 0;
            while (left > 0)
            {
                r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10); 
            }
            Console.WriteLine(rev);

            //*****Beautiful Days at the Movies
            //int i = 20;
            //int j = 23;
            //int k = 6;
            //int counter = 0;
            //int left = n;
            //int rev = 0;
            //while (left > 0)
            //{
            //    r = left % 10;
            //    rev = rev * 10 + r;
            //    left = left / 10;  //left = Math.floor(left / 10); 
            //}
            //for (int m = i; m < j; m++)
            //{
            //    if (m % k == 0)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);


            //*************Electronics Shop
            //int b = 10; //budget
            //int n = 2;  //# of keyboards models
            //int m = 3;  //# of USB drive models
            //int maxPrice = 0;
            //int[] keyboards = new int[] { 3, 1 };
            //int[] drives = new int[] { 5, 2, 8 };
            //foreach (var item in keyboards)
            //{
            //    for (int i = 0; i < drives.Length; i++)
            //    {
            //        if(item + drives[i] > maxPrice && item + drives[i] < b)
            //        {
            //            maxPrice = item + drives[i];
            //        }
            //    }
            //}
            //if(maxPrice == 0)
            //{
            //    Console.WriteLine("-1");
            //}
            //else
            //{
            //    Console.WriteLine(maxPrice);
            //}



            //************Save the Prisoner         NOT DONE
            //int n = 352926151; //# of prisoners
            //int m = 380324688; //# of treats
            //int s = 94730870; //the first chair

            //int j = m % n;
            //int finalChair = s - 1 + j;

            //Console.WriteLine(finalChair);

            //int[] a = new int[] { 1,2,3 };
            //int[] b = new int[a.Length];    //rotated array
            //int k = 2;  //rotation count
            //int q = 3;  //# of queries
            //int[] queries = new int[] { 0, 1, 2 };

            //b[0] = a[a.Length - k];
            //for
            //for (int i = 1; i < a.Length; i++)
            //{
            //    b[i] = b[i - k];
            //}


            //for (int i = 1; i <= k; i++)
            //{
            //    b[0] = a[a.Length -1];   
            //    for (int j = 1; j < a.Length; j++)
            //    {
            //        b[j] = a[j - 1];
            //    }
            //}
            //for (int t = 0; t < queries.Length; t++)
            //{
            //    c[k] = b[queries[t]];
            //}
            //foreach (var item in queries)
            //{
            //    Console./*WriteLine*/(b[item]);
            //}
            //return c;
            //foreach (var item in b)
            //{
            //    Console.WriteLine(item);
            //}


            Console.ReadLine();

        }
    }
}
