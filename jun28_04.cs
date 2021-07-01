
using System;
namespace OddEven {
   public class Program {
      public static void Main(string[] args) {
         int[] arry = new int[100];
         int i, j = 0, k = 0,size=0;
         int[] evenArry = new int[100];
         int[] oddArry = new int[100];
         
         Console.WriteLine("Input the number of elements to be stored in the array :");
	     size = Convert.ToInt32(Console.ReadLine()); 	   
   
       Console.WriteLine("Input {0} elements in the array :",size);
       for(i=0;i<size;i++)
            {
	      Console.WriteLine("element - {0} : ",i);
   	      arry[i] = Convert.ToInt32(Console.ReadLine()); 
	    }
	    
         
         
         for (i = 0; i < size; i++) {
            if (arry[i] % 2 == 0) {
               evenArry[j] = arry[i];
               j++;
            } else {
               oddArry[k] = arry[i];
               k++;
            }
         }
         Console.WriteLine("Even numbers...");
         for (i = 0; i < j; i++) {
            Console.WriteLine(evenArry[i]);
         }
         Console.WriteLine("Odd numbers...");
         for (i = 0; i < k; i++) {
            Console.WriteLine(oddArry[i]);
         }
      }
   }
}
