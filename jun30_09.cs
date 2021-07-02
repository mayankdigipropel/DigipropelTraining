using System;

namespace evenreverse
{
    public class Assignment9
    {
        public static void Main(string[] args)
        {
            string str1 = "c# Exercises";
            Console.WriteLine("Original string: " + str1);
            Console.WriteLine("\nAfter alternating the case of each letter of the said string:\n" + reverseString(str1));
            str1 = "C# is used to develop web apps , desktop apps , mobile apps , games and much more .";
            Console.WriteLine("\nOriginal string: " + str1);
            Console.WriteLine("\nAfter alternating the case of each letter of the said string:\n" + reverseString(str1));
        }
        public static string reverseString(string str)
        {
			
            
            string[] strArry = str.Split(' ');
           
            for (int i = 0; i < strArry.Length; i++)
            {
				if(strArry[i].Length %2==0)
				{
           			 char[] array = strArry[i].ToCharArray();
       	  	 		 Array.Reverse(array);
              		 strArry[i]= new string(array);
				}
		}
			 return string.Join(" ",strArry);
    }
}
}