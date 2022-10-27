using OOPLesson3;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boy boy = new Boy(1,"sdf","koko");
            Console.WriteLine(boy.boolen);
            Console.WriteLine($"{boy.Age},{boy.Name},{boy.Koko}");
            
        }
    }


}