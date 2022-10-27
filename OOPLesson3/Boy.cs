using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson3
{
    internal class Boy
    {
        public static int counter;
        public int Age { get; set; }
        public string Name { get; set; }
        public string Koko { get; set; }
        public bool boolen { get; set; }
        //ctor

        //יקרא ראשון בזמן יצירת האובייקט
        //לאחר מכן לא יקרא בשנית
        static Boy()
        {
            counter++;
        }

        public Boy(string name, int age)
        {
            Name = name;
            Age = age;
           
        }


        public Boy(int age, string name, string koko)
         : this(age, name)
        {
            Koko = koko;
            //counter++;
        }

        public Boy(int age, string name)
        {
            Name = name;
            Age = age;

        }

        public static void Print()
        {
            Console.WriteLine($"hello world");
        }



    }
}
