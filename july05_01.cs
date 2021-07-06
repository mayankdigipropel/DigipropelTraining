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
            persons[i] = new Person() {
                Name = Console.ReadLine()
			};
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
 
        public override string ToString()
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
