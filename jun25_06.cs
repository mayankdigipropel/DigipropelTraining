using System;

public class Stringcheck 
{
  static void Main(string[] args)
        {
           string firstword; 
           Console.Write("Input a string : ");
           firstword = Console.ReadLine();
           
           if (firstword.Length == 5 && firstword.Equals("Hello"))
           {
               Console.WriteLine("true" + " " + "String starts with a specified word Hello");
           }
           else
           {
               Console.WriteLine(" string doesnt match word is"+" "+ firstword );
           }
        }
}