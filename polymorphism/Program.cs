namespace MyNameSpace{
class Program{
    public static void Main(string[] args){
        Car car = new Car();
        Bike bike = new Bike();
        Truck truck = new Truck();

        Vehicle[] vehicle = {car, bike, truck};

        foreach (Vehicle v in vehicle){
            v.Go();
        }
    }
}
class Vehicle{
    public virtual void Go(){
        Console.WriteLine("Let's gooooooooooo");
    }
}
class Car : Vehicle{
        public override void Go()
        {
            Console.WriteLine("The Car is moving");
        }
    }
class Bike : Vehicle{
        public override void Go()
        {
            Console.WriteLine("The Bike is moving");
        }
}
class Truck : Vehicle{
        public override void Go()
        {
            Console.WriteLine("The Truck is moving");
        }
}
}