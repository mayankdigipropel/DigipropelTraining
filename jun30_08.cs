using System;
using System.Text;
namespace altcaps
{
   public class Program
    {
       public static void Main(string[] args)
        {
 		
            string str = "C# is used to develop web apps, desktop apps, mobile apps, games and much more.";
            Console.WriteLine("Original string:   " + str);
            
            char[] ch = str.ToCharArray();
            StringBuilder sb = new StringBuilder(); // referred srikanthpayavula code for stringbuilder

            for (int i = 0; i < ch.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ch[i] = char.ToUpper(ch[i]);

                }
               
                sb.Append(ch[i].ToString());

            }

            Console.WriteLine(sb.ToString());
		}
	}
}

        
        