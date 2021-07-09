using System;
// declaring public class Person 
public class Person
{
    int age;
    public void greet()
    {
        Console.WriteLine("Hello!");
    }
    public void SetAge(int n)
    {
        age = n;
    }
}
    // taking Student and Teacher classes inherit from the Person class
    public class Student : Person
    {
       
        public void study()
        {
            Console.WriteLine("I'm studying on the screen"); //declaring as per instructions from snippets
        }
        public void ShowAge()
        {
        Console.WriteLine("My age is: 23 years old on the screen");  //declaring as per instructions from snippets
        }
    }
    public class Teacher : Person
    {
        public void explain()
        {
            Console.WriteLine("I'm explaining on the screen"); //declaring as per instructions from snippets
        }
    }
    // Main method for output that are defined in public class Person
    public class StudentProfessorTest
    {
        public static void Main()
        {
            Person obj1 =new Person();
            obj1.greet();
           
           
            Student obj2 =new Student();
            obj2.greet();
            obj2.SetAge(25);
            obj2.ShowAge();
            obj2.study();
           
            Teacher obj3 =new Teacher();
            obj3.explain();
            obj3.SetAge(34);
            obj3.greet();
        }
    }
    /*
    Hello!
Hello!
My age is: 23 years old on the screen
I'm studying on the screen
I'm explaining on the screen
Hello!

    */