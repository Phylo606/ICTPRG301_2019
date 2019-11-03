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

            

            AddStudent("Jimmy", 1990, 180, "male", "405", (2016, 6, 3, 0, 0, 0), { "Programming", "Copyright & Ethics", "Project Management" }  );
            
            List<string> jimmysunits = new List<string> { "x", "y", "z" };
            Console.WriteLine(jimmysunits[0]);

            Console.WriteLine("Pick an option using the numbers on your keyboard:");
            Console.WriteLine(" (1) -> Create Student");
            Console.WriteLine(" (2) -> Create Teacher");
            Console.WriteLine(" (3) -> Create Admin");
            Console.WriteLine(" (4) -> Delete Student");
            Console.WriteLine(" (5) -> Delete Teacher");
            Console.WriteLine(" (6) -> Delete Admin");

            Console.ReadLine();
        }

        static List<Person> PeopleList = new List<Person>();

        static int AddStudent(string name, int yearofbirth, float height, string gender, string id, DateTime enroleddate, List<string> units)
        {
            var index = PeopleList.Count;
            Student t = new Student(name, yearofbirth, height, gender, id, enroleddate, units);
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
        public Student(string name, int yearofbirth, float height, string gender, string id, DateTime enroleddate, List<string> units) : base(name, yearofbirth, height, gender)
        {
            this.Id = id;
            this.EnrolledDate = enroleddate;
            this.Units = units;
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