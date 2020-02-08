using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6] { 82, 95, 96, 75, 85, 62 };
            result objR = new result();
            double avg = objR.GetAverageMarks(marks);
            objR.DisplayAverage(avg);
            objR.ShowGrade(avg);
        }
    }
    public interface Iexam
    {
        double GetAverageMarks(int[] marks);
        void DisplayAverage(double avg);
    }
    public interface Istudent
    {
        void ShowGrade(double avg);
    }
    public class result : Iexam, Istudent
    {
        public void DisplayAverage(double avg)
        {
            Console.WriteLine("the average of marks = {0} ", avg);
        }
        public double GetAverageMarks(int[] marks)
        {
            int total = 0;
            double avg;
            for (int i = 0; i < marks.Length; i++)
            {
                total += marks[i];
            }
            avg = total / marks.Length;
            return avg;
        }
        public void ShowGrade(double avg)
        {
            if (avg >= 70)
            {
                Console.WriteLine("First class with distrinction");
            }
        }
    }
}
