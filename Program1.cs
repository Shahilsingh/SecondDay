using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program1
    {
        static void Main(string[] args)
        {
            int a;
            int b;


            Console.Write("a:");
            a = int.Parse(Console.ReadLine());


            Console.Write("b:");
            b = int.Parse(Console.ReadLine());

            int result = mymethod(a, b);

            Console.WriteLine("a + b = {0}",result);

            Console.ReadLine();

        }
        static int mymethod(int a,int b)
        {
            var result = a + b;
            return result;
        }
    }
}
