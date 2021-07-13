using System;
    public class Student //defining a class with private variables
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;
		private static double servicetax = 12.3; //defined for 2nd condition of service tax

        public Student(int rollno, string name, string course)
        {   //calling the private var using this.
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

        public void Payment(int amount) //defined method for feepaid
        {
            feepaid += amount;
        }

        public void Print()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.WriteLine(feepaid);
        }

        public int DueAmount
        {

            get
            {
                return TotalFee - feepaid;
            }
        }

        public int TotalFee
        {
            get // using condition for feepaid for c# and asp.Net
            {
                double total = course == "c#" ? 2000 : 3000;
				// service tax
                 total = total + total * servicetax / 100;
                return (int) total;
            }
        }
		public static double  ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
    }

    public class AStudent
    {

        public static void Main()
        {

            Student obj1 = new Student(648, "Name: Ravi", "Course: c#");//defined for c# student
            obj1.Payment(1000);
            obj1.Print();
            Console.WriteLine(obj1.DueAmount);
			
            Student obj2 =new Student(1231, "Name: Asha", "Course: ASP.Net");//defined for asp.net student
            obj2.Payment(1000);
            obj2.Print();
     		Console.WriteLine(obj2.DueAmount);
        }
    }
	}
	/*
	output :648
Name: Ravi
Course: c#
1000
2369
1231
Name: Asha
Course: ASP.Net
1000
2369*/
