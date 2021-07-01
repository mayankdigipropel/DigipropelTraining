using System;  
public class lenString
{  
    public static void Main() 
{
    string str; /* Declares a string  */
    int length= 0;
      Console.Write("---------------------------------\n"); 	
      Console.Write("Input the string : ");
      str = Console.ReadLine();

         foreach(char chr in str)
        {
            length= length + 1;

        }

   Console.Write("Length of the string is : {0}\n\n", length);
	}
}
