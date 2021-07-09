using System;
public class HelloWorld 
{
 public static void Main() 
 {
	//asking primary date from user end
    Console.WriteLine("Enter the date (mm/dd/yyyy :");
    DateTime date1 = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Starting Date : {0}", date1);
    
    //asking second date from user end
	Console.WriteLine("Enter the next date(mm/dd/yyyy) :");
    DateTime date2 = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Seconday Date : {0}", date2);
    
    //basic condition of greater and less then
	  if (date1 < date2)
	  {
          Console.WriteLine("{0} Occurs Before {1}", date1, date2);
	  }
	 else if (date1 > date2){
		 Console.WriteLine("{0} Occurs after {1}", date1, date2);
	 }
  }
}
/*
input = Enter the date (mm/dd/yyyy) :
12/10/2000
Starting Date : 12/10/2000 12:00:00 AM

input = Enter the next date(mm/dd/yyyy) :
08/18/2015
Seconday Date : 8/18/2015 12:00:00 AM

output = 12/10/2000 12:00:00 AM Occurs Before 8/18/2015 12:00:00 AM
*/