using System;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Application");



            //Student Jimmy = new Student("Jimmy", 1990, 180, "male", "405");
            //Jimmy.Units = new List<string>() { "programming", "design", "management" };
            //Jimmy.EnrolledDate = new DateTime(2010, 8, 18);
            AddStudent("Barnes", 1992, 191, "Male", "002");

            while (true)
            {
                Console.Clear();
                DisplayAllPeople();
                Console.WriteLine("Pick an option using the numbers on your keyboard:");
                Console.WriteLine(" (1) -> Create Student");
                Console.WriteLine(" (2) -> Create Teacher");
                Console.WriteLine(" (3) -> Create Admin");
                Console.WriteLine(" (4) -> Delete Student");
                Console.WriteLine(" (5) -> Delete Teacher");
                Console.WriteLine(" (6) -> Delete Admin");

                Console.ReadLine();
            }
            /*Console.WriteLine(Jimmy.Name);
            Console.WriteLine(Jimmy.GetAge());
            Console.WriteLine(Jimmy.Height);
            Console.WriteLine(Jimmy.Gender);
            Console.WriteLine(Jimmy.Id);
            Console.WriteLine(Jimmy.Units[0]);
            Console.WriteLine(Jimmy.EnrolledDate);*/
         
            //List<string> jimmysunits = new List<string> { "x", "y", "z" };
            //Console.WriteLine(jimmysunits[0]);            
        }

        static List<Person> PeopleList = new List<Person>();

        static int AddStudent(string name, int yearofbirth, float height, string gender, string id)
        {
            var index = PeopleList.Count;
            
            Student t = new Student(name, yearofbirth, height, gender, id);
            t.EnrolledDate = DateTime.Now;
            t.Units = new List<string>() { "Programming", "Design", "Ethics" };
            PeopleList.Add(t);

            return index;
        }

        static void DisplayPerson(int index)
        {
            var name = PeopleList[index].Name;
            Console.WriteLine(" - " + name);
        }

        static void DrawSeperator()
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", Console.BufferWidth)));
        }

        static void DisplayAllPeople()
        {
            DrawSeperator();
            for (int i = 0; i < PeopleList.Count; i++)
            {
                DisplayPerson(i);
            }

            DrawSeperator();
        }

        static void CreateNewPerson()
        {
            Console.WriteLine("Create student: ");
            Console.WriteLine("What is the student's name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is the student's year of birth?");
            int yearofbirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How tall is the student in centimetres?");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("What is the student's gender?");
            string gender = Console.ReadLine();

            Console.WriteLine("Select what type of person you wish to create");
            Console.WriteLine(" (1) -> Student");
            Console.WriteLine(" (2) -> Staff Member");

            var k = Console.ReadKey();
            if(k.Key == ConsoleKey.D1)
            {
                Console.WriteLine("What is the student's id?");
                string id = Console.ReadLine();

                AddStudent(name, yearofbirth, height, gender, id);
            }
            else if(k.Key == ConsoleKey.D2)
            {
                Console.WriteLine("What is the staff member's ID?");
                string id = Console.ReadLine();
                Console.WriteLine("Which office does this staff member reside in?");
                string staffroom = Console.ReadLine();
                Console.WriteLine("What is the staff member's email address?");
                string email = Console.ReadLine();

                Console.WriteLine("Select what type of staff member you wish to create");
                Console.WriteLine(" (1) -> Teacher");
                Console.WriteLine(" (2) -> Admin");

                var j = Console.ReadKey();
                if(j.Key == ConsoleKey.D1)
                {

                }


            }
        }
    }

    

    public class Person
    {
        public string Name;
        public int YearOfBirth;
        public float Height;
        public string Gender;
        public int GetAge()
        {
            int age = 2019 - YearOfBirth;
            return age;
        }
        public Person(string name, int yearofbirth, float height, string gender)
        {
            Name = name;
            YearOfBirth = yearofbirth;
            Height = height;
            Gender = gender;
        }

    }

    public class Student : Person
    {
        public string Id;
        public DateTime EnrolledDate = new DateTime();
        public List<string> Units = new List<string>();
        public DateTime CalculateExpiryDate()
        {
            var ed = EnrolledDate.AddYears(2);
            return ed;
        }
        public Student(string name, int yearofbirth, float height, string gender, string id) : base(name, yearofbirth, height, gender)
        {
            this.Id = id;
        }
    }

    public class Staff : Person
    {
        public string Id;
        public string Office;
        public string Email;
        public Staff(string name, int yearofbirth, float height, string gender, string id, string office, string email) : base(name, yearofbirth, height, gender)
        {
            this.Id = id;
            this.Office = office;
            this.Email = email;
        }
    }

    public class Admin : Staff
    {
        public int ClearanceLevel;
        public string InternalPhoneNumber;
        public bool TryAccess(int LevelNeeded)
        {
            if (ClearanceLevel >= LevelNeeded)
            {
                Console.WriteLine("Access granted");
                return true;
            }
            else
            {
                Console.WriteLine("Access denied");
                return false;
            }
        }
        public Admin(string name, int yearofbirth, float height, string gender, string id, string office, string email, int clearancelevel, string internalphonenumber) : base(name, yearofbirth, height, gender, id, office, email)
        {
            this.ClearanceLevel = clearancelevel;
            this.InternalPhoneNumber = internalphonenumber;
        }
    }

    public class Teacher : Staff
    {
        public List<string> Units;
        public DateTime ContractEndDate;
        public bool HasContractExpired()
        {
            if (DateTime.Now > ContractEndDate)
            {
                Console.WriteLine("Contract has expired");
                return true;
            }
            else
            {
                Console.WriteLine("Contract is valid");
                return false;
            }
        }
        public Teacher(string name, int yearofbirth, float height, string gender, string id, string office, string email, List<string> units, DateTime contractenddate) : base(name, yearofbirth, height, gender, id, office, email)
        {
            this.Units = units;
            this.ContractEndDate = contractenddate;
        }
    }
}