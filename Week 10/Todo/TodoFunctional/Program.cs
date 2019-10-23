using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoFunctional
{
    class Program
    {

        //    static List<string> TodoTitles = new List<string>();
        //    static List<bool> TodoCompleted = new List<bool>();
        static List<Todo> TodoList = new List<Todo>();


        static int AddTodo(string title, bool completed)
        {
            var index = TodoList.Count;
            Todo t = new Todo(title, completed);
            TodoList.Add(t);
            //TodoTitles.Add(title);
            //TodoCompleted.Add(completed);

            return index;
        }
        static void RemoveTodo(int index)
        {
            TodoList.RemoveAt(index);
        }

        static void ToggleTodo(int index)
        {
            TodoList[index].Completed = !TodoList[index].Completed;
        }

        static void DisplayTodo(int index)
        {
            var title = TodoList[index].Title;
            var completed = TodoList[index].Completed;

            if (completed)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine(" - " + title);
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void DrawSepearator()
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", Console.BufferWidth)));
        }
        static void DisplayAllTodos()
        {
            DrawSepearator();
            for (int i = 0; i < TodoList.Count; i++)
            {
                DisplayTodo(i);
            }

            DrawSepearator();
        }

        static void ReadNewTodo()
        {
            Console.WriteLine("Add Todo: ");
            //(!COMPLETE!) Do stuff in here to create a new Todo.
            Console.WriteLine("Enter title of Todo: ");
            string T = Console.ReadLine();
            Console.WriteLine("Is " + "'" + T + "'" + " complete? (y or n)");
            var K = Console.ReadKey();
            if(K.Key == ConsoleKey.Y)
            {
                bool C = true;
                AddTodo(T, C);
            }
            else if(K.Key == ConsoleKey.N)
            {
                bool C = false;
                AddTodo(T, C);
            }
            
        }

        static void ReadToggleExistingTodo()
        {
            Console.WriteLine("Toggle Todo: ");
            //(!COMPLETE!) Do something to toggle the todo item thingy-ma-bob thing
            Console.WriteLine("Which Todo's status do you wish to toggle?");
            var T = Console.ReadLine();
            var Toggle = Convert.ToInt32(T);
            ToggleTodo(Toggle);
        }

        static void ReadRemoveTodo()
        {
            Console.WriteLine("Remove Todo: ");
            //(!COMPLETE!) Remove craptasic todos here
            Console.WriteLine("Which entry in the Todo list do you wish to remove? (first entry is 0, second is 1 etc etc)");
            var R = Console.ReadLine();
            var Remove = Convert.ToInt32(R);
            RemoveTodo(Remove);
        }

        public class Todo
        {
            public string Title;
            public bool Completed;

            public Todo(string title, bool completed)
            {
                Title = title;
                Completed = completed;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Todo Application");

            // Add a few example Todos
            AddTodo("Get the shopping from the store because you a lazy dude and had to pre order it", false);
            AddTodo("Kiss a tree because climate", false);
            AddTodo("Finish this task because you are a model student", false);
            AddTodo("Go to Intro Class this arvo", true);
            AddTodo("Attended Hormone treatment", false);


            while (true)
            {
                Console.Clear();
                DisplayAllTodos();
                Console.WriteLine("Pick an option:");
                Console.WriteLine(" (1) -> Create Todo");
                Console.WriteLine(" (2) -> Toggle Completed");
                Console.WriteLine(" (3) -> Remove Todo");
                Console.WriteLine(" (4) -> Exit");


                var key = Console.ReadKey(true);

                if(key.Key == ConsoleKey.D1)
                {
                    ReadNewTodo();
                }
                else if(key.Key == ConsoleKey.D2)
                {
                    ReadToggleExistingTodo();
                }
                else if(key.Key == ConsoleKey.D3)
                {
                    ReadRemoveTodo();
                }
                else if(key.Key == ConsoleKey.D4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nah you dumb, give me a valid answer please. Press any key to stop me raging at you....");
                    Console.ReadKey(true);
                }                

            }

        }
    }
}
