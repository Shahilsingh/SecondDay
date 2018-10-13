using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program5
    {
        public int SubTwoValue(int x, int y)
        {
            return x - y;
        }
        public int SubThreeValue(int x, int y, int z)
        {
            return x - y - z;
        }
    }
        public class Sub
        {

            static void Main()
           {
            Program5 p = new Program5();
            int x = p.SubTwoValue(777,666);
            int y = p.SubThreeValue(9999, 999, 99);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();



           }
        }
}
