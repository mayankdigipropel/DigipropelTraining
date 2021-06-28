using System;

namespace ArrayApplication {
   class MyArray {
      static void Main(string[] args) {
         int []  n = new int[10];

         for ( int i = 1; i < 10; i++ ) {
            n[ i ] = i + 100;
         }
         
         for ( int j = 0; j < 10; j++ ) {
            Console.WriteLine("Element[{0}] = {1}", j, n[j]);
         }
      }
   }
}
