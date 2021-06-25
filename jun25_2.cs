/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Calculator
{
  static void Main() 
  {
    
        Console.WriteLine("Enter number 1 :");
        int number1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter number 2 :");
        int number2 = Convert.ToInt32(Console.ReadLine());
   
        int result1 = number1 * number2;
        Console.WriteLine("{0} * {1} = {2}", number1, number2, result1);
        
        int result2 = number1 + number2;
        Console.WriteLine("{0} + {1} = {2}", number1, number2, result2);
        
        int result3 = number1 - number2;
        Console.WriteLine("{0} - {1} = {2}", number1, number2, result3);
        
        int result4 = number1 / number2;
        Console.WriteLine("{0} / {1} = {2}", number1, number2, result4);
    }
    
}