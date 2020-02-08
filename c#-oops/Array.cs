using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Console.WriteLine("Enter the array size");
            int a = int.Parse(Console.ReadLine());

           
            int[] marks = new int[a];

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the mark");
                marks[i] = int.Parse(Console.ReadLine());
            }

            string[] name = new string[a];

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the Name");
                name[i] = (Console.ReadLine());
            }
            
            string[,] matrix = new string[a, 2];\

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0;i < marks.Length;i++ )
            {
                Console.WriteLine("Hai {0} your Marks was {1}", name[i],marks[i]);
            }

            int b = 0;
            for(int i = 0; i < marks.Length; i++ )
            {
                b = b+marks[i]; 
            }
            double Average = b / a;

            Console.WriteLine("Average of the marks is {0}", Average);
            

            Console.ReadLine();
        }

    }
}
