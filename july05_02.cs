using System;
 
public class Program
{
    public static void Main(string[] args)
    {
        int size = 3;
	string Name;
        Person[] persons = new Person[size]; // created a array to store 3 names in it.
 
        for (int i = 0; i < size; i++) //Looping through to store each name in each index of array
        {
            persons[i] = new Person(Name = Console.ReadLine());
			
        }
 
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(persons[i]); // to display names added in array
        }
    }
}
 //Person class that has a Name property of type string
    public class Person
    {    
        public string Name { get; set; }//defined a property(string)
	public Person(string name)
        {
            Name = name;
        }
 
        public override string ToString() //declared a overring method to take the property(name) value and return Name
        {
	Console.WriteLine("Constructors are called"); //declared just to check the control flow
        return "Name :" + Name;
        }
		 ~Person() // destructor
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
