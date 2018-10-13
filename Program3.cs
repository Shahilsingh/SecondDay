using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program3
    {
       static int a =  10;
        static int b = 20;


        static void Main()
        {
            Console.WriteLine("out side swap method");
            Console.WriteLine("a is {0}", a);
            Console.WriteLine("b is {0}", b);
        

            swap(a, b);

            Console.WriteLine("out side swap method");
            Console.WriteLine("a is {0}", a);
            Console.WriteLine("b is {0}", b);
            Console.ReadLine();
        }
        static void swap(int a, int b)
        {
            int tempt;
            tempt = a;
            a = b;
            b = tempt;

            Console.WriteLine(" side swap method");
            Console.WriteLine("a is {0}", a);
            Console.WriteLine("b is {0}", b);
            
        }

    }
}
       
        