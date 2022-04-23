using System;

namespace _6_7_Praktika_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1=new Student("Seferov Malik", "Programmer");
            stu1.ShowInfo();
            Student student = new Student("Qeyyam Yaqubov","Web");     
            student.ShowInfo();
        }
    }
}
