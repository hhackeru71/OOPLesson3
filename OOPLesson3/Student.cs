using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson3
{
    internal class Student
    {
        public const double pi = 3.1415;
        public const string name = "snir";
        public string Name { get; set; }
        public int Age { get; set; }

        public static int counter;


         static Student()
        {
            counter = 0;
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            counter++;
        }

        public static string Check()
        {
            if (counter > 5)
                return "good";
            return "not good";
        }
        
     
    }
}
