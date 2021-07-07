using System;
 
public class Program
{
    public static void Main(string[] args)
    {
        int size = 3;
		string Name;
        Person[] persons = new Person[size];
 
        for (int i = 0; i < size; i++)
        {
            persons[i] = new Person(Name = Console.ReadLine());
			
        }
 
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(persons[i]);
        }
    }
}
 
    public class Person
    {
        public string Name { get; set; }
		  public Person(string name)
        {
            Name = name;
        }
 
        public override string ToString()
        {
			Console.WriteLine("Constructors are called");
            return "Name :" + Name;
        }
		 ~Person()
        {
            Name = string.Empty;
        }
    }
/*mayank
karthik
vamsi
Constructors are called
Name :mayank
Constructors are called
Name :karthik
Constructors are called
Name :vamsi*/