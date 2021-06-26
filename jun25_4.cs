using System;


class IntegerCheck {
  static void Main()
        {
           Console.WriteLine("Input 1st number:");  
           int x = Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("Input 2nd number:");  
           int y = Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("Check if one is negative and one is positive:");
           
           if ((x < 0 && y > 0) || (x > 0 && y < 0) && (x!=0 && y!=0))
           {
               Console.WriteLine("true" + " " + "one number is -ve and one is +ve");
               
           }
           else
           {
               Console.WriteLine("false");
              
           }
        }
}
