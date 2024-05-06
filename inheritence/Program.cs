class Program{
    public static void Main(string[] args)
    {
        Car car = new Car();
        Bike bike = new Bike();
        Ship ship = new Ship();

        Console.WriteLine(car.speed);
        Console.WriteLine(car.wheels);
        car.run();

        Console.WriteLine(bike.speed);
        Console.WriteLine(bike.wheels);
        bike.run();

        Console.WriteLine(ship.speed);
        Console.WriteLine(ship.wheels);
        ship.run();
    }
    class Vehicle
    {
        public int speed = 0;

        public void run()
        {
            Console.WriteLine("The vehicle is moving now...");
        }
    }
    class Car : Vehicle{
        public int wheels = 4;
    }
    class Bike : Vehicle{
        public int wheels = 2;
    }
    class Ship : Vehicle{
        public int wheels = 0;
    }
}
