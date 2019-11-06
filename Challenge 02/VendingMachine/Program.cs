using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine {
    class Program {

        static List<Item> items = new List<Item>();
        static void Main(string[] args) {
            float budget = getBudget();
            string input = "";

            while(input.ToLower() != "e") {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Would you like to: ");
                Console.WriteLine("(A)dd an item");
                Console.WriteLine("(C)heck budget");
                Console.WriteLine("(E)xit");
                Console.Write("Enter selection: ");

                input = Console.ReadLine();

                if(input.ToLower() == "a") {
                    addItem();
                } else if(input.ToLower() == "c") {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine();
                    //<--COMPLETE-->------- Add Code to calculate if items exceed the budget ----//
                    //------- Example below gets everything from items and prints name and price ----/
                    float total = 0;
                    foreach (Item i in items) {
                        Console.WriteLine(i.Name + "  $" + i.Price);
                        total = total + i.Price;
                    }
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("The budget is $" + budget);
                    Console.WriteLine("The total price of all items is $" + total);
                    if(total > budget)
                    {
                        Console.WriteLine("You are over-budget");
                    }
                    else
                    {
                        Console.WriteLine("You are within the budget");
                    }

                    // <--COMPLETE--> Print message indicating current budget and whether items exceed budget or not
                }
            }
            

            

        }

        static float getBudget() {
            string input = "";
            float price = -1f;

            Console.Write("Please enter budget: $");
            input = Console.ReadLine();
            price = float.Parse(input);
        
            return price;
        }

        static void addItem() {
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            string input = "";
            string name;
            float price = -1f;
            string itemType = "";
            string foodType = "";
            string clothingType = "";
            string visibilityselection = "";

            Console.Write("Enter Item name: ");
            name = Console.ReadLine();
        
            Console.Write("Enter Item price: $");
            input = Console.ReadLine();
            price = float.Parse(input);

            //------------- Edit from this point to implement Clothing --------//
            // Get Item type
            Console.WriteLine("Enter Item type: ");
            Console.WriteLine("(F)ood");
            Console.WriteLine("(C)lothing");
            Console.Write("Enter selection: ");
            itemType = Console.ReadLine();

            // Get data for food - this may be of use as an example
            if (itemType.ToLower() == "f") {
                int grossWeight = -1;

                Console.Write("Enter Gross Weight: ");
                input = Console.ReadLine();
                grossWeight = int.Parse(input);

                Console.WriteLine("Enter Food type: ");
                Console.WriteLine("(P)erishable");
                Console.WriteLine("(N)on Perishable");
                Console.Write("Enter selection: ");
                foodType = Console.ReadLine();

                if (foodType.ToLower() == "p") {
                    int expirymonth = 0;
                    int expiryyear = 0;

                    Console.Write("Enter Expiry Month: ");
                    expirymonth = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Expiry Year: ");
                    expiryyear = Convert.ToInt32(Console.ReadLine());

                    Perishable newPerishable = new Perishable(name, price, grossWeight, expirymonth, expiryyear);
                    items.Add(newPerishable);
                }
                else if (foodType.ToLower() == "n") {
                    int netweight = 0;

                    Console.Write("Enter Net Weight: ");
                    netweight = Convert.ToInt32(Console.ReadLine());

                    NonPerishable newNonperishable = new NonPerishable(name, price, grossWeight, netweight);
                    items.Add(newNonperishable);
                }
                else
                {
                    Console.WriteLine("Enter a proper value");
                }

                //Food newFood = new Food(name, price, grossWeight);
                //items.Add(newFood);
            }
            else if (itemType.ToLower() == "c") {
                string size = "";

                Console.Write("Enter Clothing Size: ");
                size = Console.ReadLine();

                Console.WriteLine("Enter Clothing type: ");
                Console.WriteLine("(S)afety");
                Console.WriteLine("C(A)sual");
                Console.Write("Enter selection: ");
                clothingType = Console.ReadLine();

                if (clothingType.ToLower() == "s") {
                    bool highvisibility = new bool();

                    Console.WriteLine("Is this clothing high visibility?");
                    Console.WriteLine("Y or N");
                    Console.Write("Your selection: ");
                    visibilityselection = Console.ReadLine();

                    if (visibilityselection.ToLower() == "y")
                    {
                        highvisibility = true;
                    }
                    else if (visibilityselection.ToLower() == "n")
                    {
                        highvisibility = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter a proper value");
                    }

                    Safety newSafety = new Safety(name, price, size, highvisibility);
                    items.Add(newSafety);
                }
                else if (clothingType.ToLower() == "a") {
                    string brand = "";

                    Console.WriteLine("What brand is this clothing? ");
                    brand = Console.ReadLine();

                    Casual newCasual = new Casual(name, price, size, brand);
                    items.Add(newCasual);
                }
                else
                {
                    Console.WriteLine("Enter a proper value");
                }
                //Clothing newClothing = new Clothing(name, price, size);
                //items.Add(newClothing);
            }


            // ---------------------------------------------------------------//
           
        }


        
    }

   
}
