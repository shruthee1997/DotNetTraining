using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Student emp = new Student();
            var x = emp.GetMark(25);
            Console.WriteLine(x);

            Teacher emp1 = new Teacher();
            var y = emp1.GetMark(25);
            Console.WriteLine(y);
            Console.ReadKey();
            //overloading
            Student obj = new Student();
            double avg1 = obj.avg(30, 40, 50);
            Console.WriteLine(avg1);
            double avg2 = obj.avg(30, 40, 50, 60);
            Console.WriteLine(avg2);

        }
    }
    public class Student
    {
        public virtual double GetMark(int Wrong)
        {
            int correct = 100 - Wrong;
            return correct;
        }
        public double avg(int sub1, int sub2, int sub3)
        {
            double avg = (sub1 + sub2 + sub3) / 3;
            return avg;
        }
        public double avg(int sub1, int sub2, int sub3, int sub4)
        {
            int avg = (sub1 + sub2 + sub3 + sub4) / 4;
            return avg;
        }
    }
    public class Teacher : Student
    {
        public override double GetMark(int Wrong)
        {
            int correct = 100 - Wrong;
            double d;
            if (correct < 50 && correct > 40)
            {
                d = (100 - Wrong) * 1.30;

            }
            else if (correct < 70 && correct > 50)
            {
                d = (100 - Wrong) * 1.20;

            }
            else if (correct < 80 && correct > 70)
            {
                d = (100 - Wrong) * 1.10;

            }
            else
            {
                d = (100 - Wrong) * 1.05;

            }

            return d;

        }
    }
}

