using System;
class Program
{
    static void Main(){
         int [] arr = new int[100];
         int i , j , size, count=0;
         
         Console.WriteLine("Input array size {0} =");
         size = Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine("Enter Elements in array:");
         for (i=0;i<size;i++){
             Console.WriteLine("Enter Element {0}",i);
             arr[i] = Convert.ToInt32(Console.ReadLine());
         }
         
         for(i=0;i<size;i++){
             for(j=i+1;j<size;j++){
                if (arr[i]==arr[j])
                {
                    count++;
                    break;
                }
                
             }
         }
         
        Console.WriteLine("total duplicate Elements in array : {0}", count);
    }
}    