using System;

    interface AStack // created a interface called stackA
    {
        void Push(int v); //variable declared
        int Pop(); //variable declared
        int Length { get; } //Property declared with getter 
    }

   public class StackFullException : Exception //C# exceptions are represented by classes. The exception classes in C# are mainly directly or indirectly derived from the System.Exception class
    {
        public StackFullException()
            : base("Stack Full") // this will throw an exception along with stack trace address
        {
        }
    }

   public class StackEmptyException : Exception
    {
        public StackEmptyException()
            : base("Stack Empty")
        {
        }
    }
//Created an interface called Stack above and and now defining methods Push(), Pop() and property Length
   public class Stack  : AStack 
    {
        private int[] a = new int[10];
        public int top = 0;

        public void Push(int v) 
        {

            if (top == 10)
			{
                throw new StackFullException(); // This will call class stackFullExecption
			}

            a[top] = v;
            top++;
        }

        public int Pop()
        {
		
            if (top == 0)
                throw new StackEmptyException(); //// This will call class stackEmptyExecption
			
            top--;
            return a[top];
        }

        public int Length// integer with getter as return  as top value
        {
            get
            {
                return top;
            }
        }
    }

   public class UseStack
    {
        public static void Main()
        {
            Stack s = new Stack();
            s.Push(20);

            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Length);

            //Console.WriteLine(s.Pop()); //remove the comment to see the flow goes in stackemptyexecption and will throw stack empty exeption			
			
			s.top=10;
			s.Push(20);

           
        
    }
}
/*
output:
20
0
Run-time exception (line 36): Stack Full

Stack Trace:

[StackFullException: Stack Full]
   at Stack.Push(Int32 v) :line 36
   at UseStack.Main() :line 75
   */