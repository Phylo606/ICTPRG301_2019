using System;


namespace animalexample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> myAnimals = new List<Animal>;
            Console.WriteLine("Hello World!");
            Animal myAnimal = new Animal(56, "Crane");

            myAnimals.Add(myAnimal);
            
            Fish myFish = new Fish(1,"Fishy Fish", 56, true);

            myAnimals.Add(myFish);

            Tuna myTuna = new Tuna();
            myTuna.Name = "bob";
            myAnimals.Add(myTuna);

            foreach(var animal in myAnimals)
            {
                if(animal is Fish) var MyFishy = animal as Fish)
            }

        }
    }

    public class Animal
    {
        public int Age;
        public string Gender;

        protected void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        protected Animal(int age, string gender)
        {
            this.Age = age;
            this.Gender = gender;
        }

    }

    public class Fish : Animal
    {
        public float Size;
        public bool CanEat;


        public Fish(int age, string gender, float size, bool caneat) : base(age, gender)
        {
            this.Size = size;
            this.CanEat = caneat;
        }
    }

    public class Zebra: Animal
    {
        public bool IsWild;
    }

    public class Tuna : Fish
    {
        public string Name;
    }
}
