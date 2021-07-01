/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
 class Program
    {
       
        public static void Main(string[] args)
        {
            int m, n, i, j;
            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arry1 = new int[10, 10];
            Console.Write("\nEnter The First Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arry1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] arry2 = new int[10, 10];
            Console.Write("\nEnter The Second Matrix:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arry2[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
          
            Console.WriteLine("\nMatrix arry1 : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(arry1[i, j] + "\t");
 
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMatrix arry2: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(arry2[i, j] + "\t");
 
                }
                Console.WriteLine();
            }
            
            bool flag = true;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (arry1[i, j] == arry2[i, j])
                    {
                        flag=true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == false)
                break;
            }
            if (flag)
            {
                Console.WriteLine("Matrices are Equal  ");
            }
            else
            {
                Console.WriteLine("Not Equal ");
            }            
          
        }
    }
