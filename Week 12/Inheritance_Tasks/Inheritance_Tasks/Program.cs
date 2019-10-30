using System;
using System.Collections.Generic;

namespace Inheritance_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there!");
            Console.WriteLine("What type of person would you like to create?");
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
        
    }

    public class Student : Person
    {
        public string Id;
        public DateTime EnrolledDate;
        public List<string> Units;
        public DateTime CalculateExpiryDate()
        {
            var ed = EnrolledDate.AddYears(2);
            return ed;
        }
    }

    public class Staff : Person
    {
        public string Id;
        public string Office;
        public string Email;
    }

    public class Admin: Staff
    {
        public int ClearanceLevel;
        public string InternalPhoneNumber;
        public bool TryAccess(int LevelNeeded)
        {
            if(ClearanceLevel >= LevelNeeded)
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
    }
}
