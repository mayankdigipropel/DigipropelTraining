using System;
class revarry {
  static void Main() {
      int[] a = new int[3];
      int i,n;
      Console.WriteLine("number of elements to store in array :");
      n = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("input {0} number of elements :",n);
      for(i=0;i<n;i++)
      {
          Console.WriteLine("element - {0} : ",i);
          a[i] = Convert.ToInt32(Console.ReadLine());
          
      }
      Console.WriteLine("The values in the array are : ");
      for(i=0;i<n;i++)
     {
	   Console.WriteLine("{0}  ",a[i]);
	 }
  }
}
