using System;
public class CarProgram
{
    //Defining a interface called Ivehicle with two method
    public interface Ivehicle 
    {
        void Drive();
        bool Refuel(int amount);
    }
    public class Car :Ivehicle //Car class with a builder
    {
        public int fuel{ get; set;} //To set up initial fuel value
        public Car(int Fuel)
        {
            fuel = Fuel ;
        }
        public void Drive() //Drive method will print on the screen that the car is Driving
        {
            if( fuel > 0 )
            {
                Console.WriteLine("the car is driving");
            }
            else
            {
                Console.WriteLine("No fuel, Please Refuel the Car");
            }
            
        }
        public bool Refuel(int amount)
        {
            fuel += amount;
            return true;
        }
    }
    
    public static void Main ()
    {
        Car obj1 = new Car(0);
        Console.WriteLine("Enter the speed of car:");
        int Fuel = int.Parse(Console.ReadLine());
        if (obj1.Refuel(Fuel))
        {
            obj1.Drive();
        }
    }
}
/*
Enter the speed of car:
0
No fuel, Please Refuel the Car
*/
 