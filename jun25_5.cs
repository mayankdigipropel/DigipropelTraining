using System;


class Triplesum {
  static void Main()
        {
           Console.WriteLine("Input 1st number:");  
           int x = Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("Input 2nd number:");  
           int y = Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("if two values are equal return thrive the sum:");
           
           int result = (x+y);
           
           if (x==y)
           {
               Console.WriteLine((result)*(result)*(result));
               
           }
           else
           {
               Console.WriteLine(result + " " + "the two values are not equal");
              
           }
        }
}
