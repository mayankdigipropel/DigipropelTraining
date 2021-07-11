using System;

 

  public  class Table // created a class called table 
    {
        private int width = 0; //defined private variables
        private int height = 0; //defined private variables

 

        public Table(int width, int height) //created a parameterized constructor
        {
            if (width >= 0) this.width = width;
            if (height >= 0) this.height = height;
        }
        public void ShowData()
        {
            Console.WriteLine("Height - {0} cm, width - {1} cm", height, width);
    }
   public class Program
    {
        public static void Main(string[] args)
        {
            Table[] arr = new Table[10];
            Random value = new Random(); //generate the random values for the input
            for(int i = 0; i<10; i++) // looping through
            arr[i] = new Table(value.Next(50, 200), value.Next(50,200)); 
            foreach (var i in arr)
            i.ShowData(); // writing output using loop
        }
    }
}

/*Expected Output:
Height - 70 cm, width - 123 cm
Height - 198 cm, width - 120 cm
Height - 101 cm, width - 124 cm
*/