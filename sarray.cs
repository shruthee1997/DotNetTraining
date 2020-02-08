using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sarray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[3];
            //int[] source = new int[5];

            ////arr[0] = 12;
            //arr[1] = 412;
            //arr[2] = 15;

            int[] arr = new int[5] { 9, 2, 9, 5, 2 };
            //int[] arr = new int[3] { 144, 62, 40};

            //arr[2] = 100;
            //Console.WriteLine(arr.Rank);
            //Console.WriteLine(arr[2]);

            //for(int x=0;x<arr.Length;x++)
            //{
            //    Console.WriteLine(arr[x]);
            //}

            //foreach(int x in arr)
            //{
            //    Console.WriteLine(x);
            //}

            // //for(int x=0; x< )
            // Console.WriteLine(Array.IndexOf(arr, 2));
            // Array.Sort(arr);

            // Array.Reverse(arr);
            //int[]last= arr.Distinct().ToArray();
            // Console.WriteLine(last[0]);


            //int[,] twod = new int[2, 4] { { 11, 12, 13, 14 }, { 21, 22, 23, 24 } };
            //Console.WriteLine(twod.Rank);
            //Console.WriteLine(twod.Length);
            //Console.WriteLine(twod.GetLowerBound(0));
            //Console.WriteLine(twod.GetUpperBound(1));


            int[,] jag = new int[3,2] { { 11, 12 },{ 13, 14 }, { 21, 22 } };
            //Console.WriteLine(twod.Rank);
            //Console.WriteLine(twod.Length);
            //Console.WriteLine(twod.GetLowerBound(0));
            //Console.WriteLine(twod.GetUpperBound(1));
            for (int x = 0; x <= jag.GetLength(0)-1; x++)
            {
                for (int y = 0; y <= jag.GetLength(1)-1; y++)
                {
                    Console.WriteLine(jag[x,y]);
                }
            }

            //int[][] jag = new int[4][];
            //jag[0] = new int[3] { 4, 6, 34 };
            //jag[1] = new int[4] { 45,4, 6, 34 };
            //jag[2] = new int[2] { 76, 34 };
            //jag[3] = new int[3] { 49, 16, 34 };
            ////Console.WriteLine(jag[1].Length);
            ////Console.WriteLine(jag[2][1]);

            //for (int x = 0; x < jag.Length; x++) 
            //{
            //    for (int y = 0; y < jag[x].Length; y++)
            //    {
            //        Console.WriteLine( jag[x][y] );
            //    }
            //}

            








        }
    }
}
