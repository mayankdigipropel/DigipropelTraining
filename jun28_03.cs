using System;  
public class Exercise8  
{  
    public static void Main() 
{
	int[] arr = new int[100];
	int[] dup = new int[100];
    int n, i, j, count;
	
	
       Console.WriteLine("Count the frequency of each element of an array:");
	

       Console.WriteLine("Input the number of elements to be stored in the array :");
	   n = Convert.ToInt32(Console.ReadLine()); 	   
   
       Console.WriteLine("Input {0} elements in the array :",n);
       for(i=0;i<n;i++)
            {
	      Console.WriteLine("element - {0} : ",i);
   	      arr[i] = Convert.ToInt32(Console.ReadLine()); 		  
		  dup[i] = -1;
	    }
    for(i=0; i<n; i++)
    {
        count = 1;
        for(j=i+1; j<n; j++)
        {
            if(arr[i]==arr[j])
            {
                count++;
                dup[j] = 0;
            }
        }

        if(dup[i]!=0)
        {
            dup[i] = count;
        }
    }
    Console.WriteLine("The frequency of all elements of the array : ");
    for(i=0; i<n; i++)
    {
        if(dup[i]!=0)
        {
            Console.WriteLine("{0} occurs {1} times", arr[i], dup[i]);
        }
    }
  }	
}
