using System;


    public class WordPosition
    {
        public static void Main(string[] args)
        {
            string str1 = "Today is a fine thrusday morning"; //defined a statement
            Console.WriteLine("Original string: " + str1);
            //using a function as test ,for other class to call it
            Console.WriteLine("Position of the word 'is' in the said string: " + test(str1, "is"));
            Console.WriteLine("Position of the word 'fine' in the said string: " + test(str1, "fine"));
            Console.WriteLine("Position of the word 'morning' in the said string: " + test(str1, "morning"));
        }
        public static int test(string text, string word) // method to call our test function
        {
            
            string[] arry = text.Split(' '); // separating the statemnt and putting it in string array seperated by spaces
            return Array.IndexOf(arry, word)+1;
       
        }
    }
    /*Original string: Today is a fine thrusday morning
Position of the word 'is' in the said string: 2
Position of the word 'fine' in the said string: 4
Position of the word 'morning' in the said string: 6/*
