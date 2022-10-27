using OOPLesson3;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boy boy1 = new Boy(1,"sdf","koko");
            Console.WriteLine(Boy.counter);//
            Boy boy2 = new Boy(1, "sdf", "koko");
            Console.WriteLine(Boy.counter);//
            Boy boy3 = new Boy(1, "sdf", "koko");
            Console.WriteLine(Boy.counter);//
            Boy.Print();
            //Console.WriteLine(boy1.boolen);
            //Console.WriteLine($"{boy1.Age},{boy1.Name},{boy1.Koko}");


        }
    }


}