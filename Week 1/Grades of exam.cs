using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fed._14._2021_Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            int marks;
            Console.WriteLine("Enter the marks");
            //Convert the string to integer
            marks = Convert.ToInt32(Console.ReadLine());
            if (marks == 40)
                Console.WriteLine("Fall");
            else if (marks == 60)
                Console.WriteLine("Good Work");
            else if (marks == 80)
                Console.WriteLine("Exellent");
            else
                Console.WriteLine("Not attented the exam");
        }
    }
}
