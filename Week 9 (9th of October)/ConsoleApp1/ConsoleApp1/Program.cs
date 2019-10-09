using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            //Tasks 1 and 1.1 Answers: 

            //Create two new people (of the Person class) with names, ages and Dates of Birth (Dob) 

            Person Player1 = new Person("Rob", 19, "14/03/2000");
            Person Player2 = new Person("Don", 22, "27/06/1997");
            Console.WriteLine(Player1.Name + " is " + Player1.Age + " years old and was born on " + Player1.Dob + ".");
            Console.WriteLine(Player2.Name + " is " + Player2.Age + " years old and was born on " + Player2.Dob + ".\n");

            //Task 2 Answer:

            //Ask for a name, assign that name to a new person and add that person to a list of people known as "p". Do this until integer "i" equals 5 (ergo "Do this process five times")

            for (int i = 1; i <= 5; i++)
            {
                Person p = new Person("");
                Console.WriteLine("Enter a name for person number " + i + ": ");
                p.Name = Console.ReadLine();
                people.Add(p);
            }

            //Linebreak for legibility: 

            Console.WriteLine("");

            //For each person in the "p" list, list their name on a single line

            foreach (Person item in people)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    public class Todo
    {
        public string Title;
        public bool State;

        public Todo(string title)
        {
            Title = title;
        }
    }

    public class Person
    {
        public string Name;
        public int Age;
        public string Dob;


        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person(string name, int age, string dob)
        {
            Name = name;
            Age = age;
            Dob = dob;
        }
    }
}
