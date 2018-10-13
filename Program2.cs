using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two nums");
                int result;
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                    result = num1;
                else
                    result = num2;
            Console.WriteLine("the max value is:" + result);
            Console.ReadLine();
        }

    }
}
