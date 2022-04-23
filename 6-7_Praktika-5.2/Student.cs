using System;
using System.Collections.Generic;
using System.Text;

namespace _6_7_Praktika_5._2
{
    public class Student
    {
        private  int _id;
        public static int IdCount = 0;
        public string FullName;
        public string Subject;
        private int _groupid;
        public static int GroupCount = 1000;

        public Student(string fullname,string subject)
        {
            IdCount++;
            _id = IdCount;
            GroupCount++;
            _groupid = GroupCount;
            FullName = fullname;
            Subject = subject;
            
        }

        public void GroupName(string subject)
        {           
            Console.WriteLine(char.ToUpper(subject[0]).ToString() + char.ToUpper(subject[1]).ToString() + GroupCount);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {IdCount}  |  FullName:{FullName}  |  Subject:{Subject}  | GroupCount:{GroupCount}");
        }
    }
}
