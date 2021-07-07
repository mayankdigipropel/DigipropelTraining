using System;
 
public class Program
{
    public static void Main(string[] args) 
    {
        int size = 3;
		string Name;
        Person[] persons = new Person[size]; // line 9 to 14 defines three names of people from the user and stores them in an array of objects of type Person
 
        for (int i = 0; i < size; i++)
        {
            persons[i] = new Person() {
                Name = Console.ReadLine()
			};
        }
 
        for (int i = 0; i < size; i++) //looping for to get display of input names(ToString by default egConsole.WriteLine(persons[i].ToString) )
        {
            Console.WriteLine(persons[i]);
        }
    }
}
 
    public class Person
    {
        public string Name { get; set; } //using get method returns the value of the variable name
 					// using set method assigns a value to the name variable
        public override string ToString() //Name property of type string and override the ToString() method
        {
            return "Name :" + Name;
        }
    }
    Compilation succeeded - 1 warning(s)
/*
m
a
k
Name :m
Name :a
Name :k*/
