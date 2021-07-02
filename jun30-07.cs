using System;
using System.Linq;
namespace touppercase
{
    public class Assignment07
    {
        public static void Main(string[] args)
        {
            string str1 = "python exercises";
            Console.WriteLine("Original string: " + str1);
            //function call to test () with string parameter which returns string
            Console.WriteLine("After converting string to camalcase:\n" + test(str1));
            
            str1 = "The quick brown Fox jumps over the little lazy Dog";
            Console.WriteLine("\nOriginal string: " + str1);
            Console.WriteLine("After converting the string to camalcase:\n" + test(str1));
        }
       public static string test(string str1)
        {
            //spliting the string by space into string array
		  string[] strArry = str1.Split(' ');
		   for (int i= 0; i<strArry.Length; i++)
		   {
		       //converting the 1st character of substring to uppercase and adding rest of substring
			   strArry[i] =  strArry[i].Substring(0, 1).ToUpper() +  strArry[i].Substring(1);
		   }
		   
            return string.Join(" ",strArry);
        }
    }
}
