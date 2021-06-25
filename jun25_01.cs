/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Multiplier 
{
  static void Main() 
  {
    
        Console.WriteLine("Enter number 1 :");
        int number1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter number 2 :");
        int number2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter number 3 :");
        int number3 = Convert.ToInt32(Console.ReadLine());
        
        int result = number1 * number2 * number3;
        Console.WriteLine(result);
        
    }
    
}