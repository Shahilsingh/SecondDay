using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program4
    {
        public int AddTwoValue(int x, int y)
        {
            return x + y;
        }
        public int AddThreeValue(int x, int y, int z)
        {
            return x + y + z;
        }
    }
        public class MethodParameters
        {
            static void Main()
            {
                Program4 p = new Program4();
                int x = p.AddTwoValue(20,40);
                int y = p.AddThreeValue(30,60,10);
                 Console.WriteLine(x);
                  Console.WriteLine(y);
                 Console.ReadLine();
            }
        }


}

