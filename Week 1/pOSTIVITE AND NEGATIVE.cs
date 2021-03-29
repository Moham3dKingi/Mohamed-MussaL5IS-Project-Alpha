using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_And_Negative_Numbersj
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((num  >= 0) ? "Number is Positive"
                : "Number is Negative");
            Console.ReadKey();
        }
    }
}
