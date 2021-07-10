using System;
class RandomNumberGenerator
{
    static void Main()
    {
    //Random class provides functionality to generate random numbers in C#
      Random random = new System.Random();
      Console.WriteLine("First Random Number is :" +(random.Next(0,1000))); //will generate randon no ranging 0 to 1000
      Console.WriteLine("2nd random Number is : "+(random.Next(20,50)));//will generate randon no ranging 20 to 50
      Console.WriteLine("3rd random Number is : "+(random.Next(10,50)));//will generate randon no ranging 10 to 50
    }
}
/*
First Random Number is :280
2nd random Number is : 23
3rd random Number is : 37
*/