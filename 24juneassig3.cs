/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Atm {
  static void Main() {
    Console.WriteLine("Customer");
    string name;
    int pin;
    Console.WriteLine("Enter your name:");
    name = Console.ReadLine();
    
    Console.WriteLine("Enter your pin");
    pin = Convert.ToInt32(Console.ReadLine());
    
    if(pin == 1234){
        Console.WriteLine("Dear"+ " " + name + " "+ "wait for your transaction to complete" );
    }
    else{
        Console.WriteLine("Dear" +" " + name +" "+ "incorrect pin");
    }
  }
}