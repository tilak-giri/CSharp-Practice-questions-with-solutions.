class Program{
    public static void Main(string[] args){
        Car[] garrage = {new Car("Corvette"), new Car("Ferrari"), new Car("Lamborghini")};

        foreach (Car car in garrage)
        {
            Console.WriteLine(car.model);
        }
    }
    class Car{
        public string model;
        public Car(string model){
            this.model = model;
        }
    }
}