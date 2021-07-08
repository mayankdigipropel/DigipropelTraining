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
            str1 = "C# is used to develop web apps , desktop apps , mobile apps , games and much more ."; // defined a statement for alternating
            Console.WriteLine("\nOriginal string: " + str1);
            Console.WriteLine("\nAfter alternating the case of each letter of the said string:\n" + reverseString(str1));
        }
        public static string reverseString(string str)
        {
			
            
            string[] strArry = str.Split(' '); // spit the array and stored the words in indexes seperated by spaces.
           
            for (int i = 0; i < strArry.Length; i++)
            {
				if(strArry[i].Length %2==0)
				{
           			 char[] array = strArry[i].ToCharArray(); //using character array for each alphabet to reverse
       	  	 		 Array.Reverse(array);
              		 strArry[i]= new string(array); //after changing alphabet storing the words in string arrays again
				}
		}
			 return string.Join(" ",strArry);
    }
}
}
/*Original string: c# Exercises

After alternating the case of each letter of the said string:
#c Exercises

Original string: C# is used to develop web apps , desktop apps , mobile apps , games and much more .

After alternating the case of each letter of the said string:
#C si desu ot develop web sppa , desktop sppa , elibom sppa , games and hcum erom .*/
