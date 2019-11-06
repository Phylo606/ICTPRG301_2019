using System;
 
 namespace VendingMachine {
     public class Item {
         public string Name;
         public float Price;
     }
 
     public class Food : Item {
         public int GrossWeight;
 
         public Food(string n, float p, int gw) {
             Name = n;
             Price = p;
             GrossWeight = gw;
         }

         public void Eat() {
             GrossWeight = 0;
         }
     }
 
     public class Perishable : Food {
         public int ExpiryMonth;
         public int ExpiryYear;
 
         public Perishable(string n, float p, int gw, int em, int ey) : base(n, p, gw) {
             ExpiryMonth = em;
             ExpiryYear = ey;
         }
     }
 
     public class NonPerishable : Food {
         public int NetWeight;
 
         public NonPerishable(string n, float p, int gw, int nw) : base(n, p, gw) {
             NetWeight = nw;
         }
     }
 
     //----------------------------------------------------------//
     // Use the Food classes as an example to complete Clothing,
     // Safety and Casual.  Hint:  Think about inheritence
     //----------------------------------------------------------//
     public class Clothing : Item {
         public string Size;

         public Clothing(string n, float p, string s)
         {
             Name = n;
             Price = p;
             Size = s;
         }
     }
 
     //------- These two are part of the optional task ---------//
     public class Safety : Clothing {
         public bool HighVisibility;

         public Safety(string n, float p, string s, bool h) : base(n, p, s)
         {
            HighVisibility = h;
         }
     }
 
     public class Casual : Clothing {
         public string Brand;

         public Casual(string n, float p, string s, string b) : base(n, p, s)
         {
             Brand = b;
         }
     }
     //----------------------------------------------------------//
 
 }