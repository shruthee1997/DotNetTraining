using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {   
        static void Main(string[] args)
        {
            int j;
           
            int[,] matrix = new int[3, 3] { { 1, 2, 3, }, { 4, 5, 6, }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }



            int[] marks = new int[6];
            marks[0] = 90;
            marks[1] = 80;
            marks[2] = 70;
            marks[3] = 300;
            marks[4] = 20;
            marks[5] = 10;
            
            string[] names = new string[6];

            names[0] = "sai";
            names[1] = "ram";
            names[2] = "sai";
            names[3] = "ram";
            names[4] = "sai";
            names[5] = "ram";





            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("hello {0} your marks was {1}",   names[i], marks[i] );

            }
            int b = 0;
            for(int i=0; i < marks.Length;i++)
            {
                b = b + marks[i];
            } 
           int avg = b / 6;
            Console.WriteLine("avg of Marks is {0}", avg);

            


        } 

    }
}
