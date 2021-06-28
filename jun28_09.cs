using System;
  
class ascarry {
    public static void Main()
    {
        int[] numbers = new int[] {2, 7, 4, 5, 9};
        Array.Sort(numbers);
        foreach(int value in numbers)
        {
            Console.Write(value);
        }
    }
}