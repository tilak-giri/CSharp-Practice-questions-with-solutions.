using System;
namespace MyProgram{
    class Program{
    public static void Main(string[] args){
        Car car = new Car();
        Bike bike = new Bike();

        car.wheels();
        bike.wheels();
    }
}
class Vehicle{
    public virtual void wheels(){
        Console.WriteLine("The vehicle have 4 wheels...");
    }
}
class Car : Vehicle{
}
class Bike : Vehicle{
    public override void wheels(){
        Console.WriteLine("The vehicle have 2 wheels...");
    }
}
}