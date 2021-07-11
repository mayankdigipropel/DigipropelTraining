using System;
public  class Table // created a class called Table
    {
        //  declared private variables
        private int width = 0; 
        private int height = 0; 

        public Table(int width, int height)   //created parameterized constructor
        {
            if (width >= 0) this.width = width;
            if (height >= 0) this.height = height;
        }
        public void ShowData()
        {
            Console.WriteLine("Height - {0} cm, width - {1} cm", height, width);
        }
        public static void Main(string[] args)
        {
            Table[] arr = new Table[10];
            Random value = new Random();  //generate random values in arr
            for(int i = 0; i<10; i++)
                arr[i] = new Table(value.Next(50, 200), value.Next(50,200));
            foreach (var i in arr)
                i.ShowData();
        }
}
/*
Height - 172 cm, width - 148 cm
Height - 119 cm, width - 97 cm
Height - 83 cm, width - 193 cm
Height - 143 cm, width - 95 cm
Height - 80 cm, width - 60 cm
Height - 109 cm, width - 186 cm
Height - 182 cm, width - 119 cm
Height - 167 cm, width - 60 cm
Height - 156 cm, width - 100 cm
Height - 69 cm, width - 111 cm*/