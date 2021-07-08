using System;
using System.Text;
namespace altcaps
{
   public class Program
    {
       public static void Main(string[] args)
        {
 		
            string str = "C# is used to develop web apps, desktop apps, mobile apps, games and much more."; //defined the statement
            Console.WriteLine("Original string:   " + str);
            
            char[] ch = str.ToCharArray(); // seperating the statement in character array for each character
            StringBuilder sb = new StringBuilder(); // referred srikanthpayavula code for stringbuilder

            for (int i = 0; i < ch.Length; i++)
            {
                if (i % 2 == 0) //declaring condition for even no words
                {
                    ch[i] = char.ToUpper(ch[i]); //if even change the alphabet to camalcase

                }
               //string.join method not used here
                sb.Append(ch[i].ToString()); // joining the alphabets to make a whole statement again 

            }

            Console.WriteLine(sb.ToString());
		}
	}
}
/*Original string:   C# is used to develop web apps, desktop apps, mobile apps, games and much more.
C# iS UsEd tO DeVeLoP WeB ApPs, DeSkToP ApPs, MoBiLe aPpS, gAmEs aNd mUcH MoRe.*/
        
        
