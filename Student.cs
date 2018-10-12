using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string name;
        public int age;
        public int marks;
        public void detail()
        {
            Console.WriteLine("name = {0} Age = {1} Marks = {2}", name, age, marks);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Student std = new Student();
                std.age = 22;
                std.name = "Shahil";
                std.marks = 89;
                std.detail();
                Console.ReadKey();
            }

        }
    }
}
