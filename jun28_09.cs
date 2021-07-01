using System;
namespace Demo {
   public class MyApplication {
      public static void Main(string[] args) {

    int n, j, tmp;
    Console.WriteLine("Input the size of array : ");
    n = Convert.ToInt32(Console.ReadLine()); 
 int[] list = new int[n] ;
       Console.WriteLine("Input {0} elements in the array :",n);
       for(int i=0;i<n;i++)
            {
	      Console.Write("element - {0} : ",i);
		 list[i] = Convert.ToInt32(Console.ReadLine());  
	    }
         Console.WriteLine("Original Unsorted List");
         foreach ( int i in list) {
            Console.Write(i + " ");
         }
         Array.Sort(list);
         Console.WriteLine("Sorted List");
         for( int i=0; i<list.Length; i++) {
            Console.Write(list[i] + " ");
         }
      }
   }
}
