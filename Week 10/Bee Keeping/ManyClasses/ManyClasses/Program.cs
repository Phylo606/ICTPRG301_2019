using System;
using System.Collections.Generic;


namespace ManyClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var studentClass = new StudentClass();
            studentClass.Name = "Intro Programming";
            studentClass.StartTime = "8:30";
            studentClass.EndTime = "13:30";

            var student1 = new Student();
            student1.Age = 31;
            student1.FirstName = "Bob";
            student1.LastName = "Joe";
            student1.HappyBirthday();

            var student2 = new Student();
            student2.Age = 564;
            student2.FirstName = "Frank";
            student2.LastName = "Pooped";

        }
    }

    public class StudentClass
    {
        public string Name;
        public string StartTime;
        public string EndTime;

        public List<Student> Students = new List<Student>();
    }

    public class Student
    {
        public string Id;
        public string FirstName;
        public string LastName;

        public int Age;

        public string PhoneNumber;

        public void HappyBirthday()
        {
            Age = Age + 1;
        }
    }
}
