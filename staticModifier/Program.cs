class Program{
    public static void Main(string[] args)
    {
        Car car1 = new Car("Ferrari");
        Car car2 = new Car("Supra");
        Car car3 = new Car("Ford");
        Console.WriteLine($"Numbers of cars in the race are : {Car.carCounter}");
        Car.Drive();
    }
}
class Car
{
    public string model;
    public static int carCounter;
    public Car(string model)
    {
        this.model = model;
        carCounter += 1;
    }
    public static void Drive()
    {
        Console.WriteLine($"The race has begun!!!");
    }
}