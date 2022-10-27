using OOPLesson3;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //לא ניתן ליצור אובייקטים ממחלקה סטטית
            //במחלקה סטטית כל  המתודות המשתנים חייבים להיות מוגדרים כסטטיים
            //ניגש למתודות / משתנים ע"י המחלקה עצמה
            Student s1 = new Student("sdf", 30);
            Console.WriteLine(Student.Check());
            Student s2 = new Student("sdf", 30); 
            Student s3 = new Student("sdf", 30);
            Student s4 = new Student("sdf", 30);
            Student s5 = new Student("sdf", 30);
            Student s6 = new Student("sdf", 30);

            Console.WriteLine(Student.counter);//
            Console.WriteLine(Student.Check());


            //Boy boy1 = new Boy(1,"sdf","koko");
            //Console.WriteLine(Boy.counter);//
            //Boy boy2 = new Boy(1, "sdf", "koko");
            //Console.WriteLine(Boy.counter);//
            //Boy boy3 = new Boy(1, "sdf", "koko");
            //Console.WriteLine(Boy.counter);//
            //Boy.Print();

            //Console.WriteLine(boy1.boolen);
            //Console.WriteLine($"{boy1.Age},{boy1.Name},{boy1.Koko}");


        }
    }


}