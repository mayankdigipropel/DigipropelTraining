using System;
public abstract class Animal 
{
    private string Name;
    
    public void SetName(string name)
    {
        Name=name;
    }
    public string GetName()
    {
        return Name ;
    }
    public abstract void Eat();
}
// defining a AbstractClass
public class AbstractClass
{
    public class Dog : Animal
{
public override  void Eat()
{
Console.WriteLine("The Dog is Eating ");
}
    public static void Main()
    {
        Dog obj1 = new Dog();
        Console.WriteLine("Enter The Name of Dog ");
        obj1.SetName("Dog's Name : "+Console.ReadLine());
        Console.WriteLine (obj1.GetName());
        obj1.Eat();
    
    }
}
}