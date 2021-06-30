using System;
class sumArray
{
    static void Main()
    {
    
    int[] a = new int [10];
    int i,n ,sum=0;
    
    Console.WriteLine("Enter the size of array :");
    n = Convert.ToInt32(Console.ReadLine());
    
    for (i=0;i<n;i++)
    {
        Console.WriteLine("index[{0}] : ",i);
        a[i] = Convert.ToInt32(Console.ReadLine());
        
    }
     for (i=0;i<n;i++)
    {
        sum = sum + a[i];
    }
    Console.WriteLine("sum of arrays is : {0}", sum);
 }
}
