using System;


    public class WordPosition
    {
        public static void Main(string[] args)
        {
            string str1 = "Today is a fine thrusday morning";
            Console.WriteLine("Original string: " + str1);
            Console.WriteLine("Position of the word 'is' in the said string: " + test(str1, "is"));
            Console.WriteLine("Position of the word 'fine' in the said string: " + test(str1, "fine"));
            Console.WriteLine("Position of the word 'morning' in the said string: " + test(str1, "morning"));
        }
        public static int test(string text, string word)
        {
            
            string[] arry = text.Split(' ');
            return Array.IndexOf(arry, word)+1;
       
        }
    }

