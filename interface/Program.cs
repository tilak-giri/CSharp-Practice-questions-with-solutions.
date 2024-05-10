namespace MyNameSpace{
    class Program{
        static void Main(string[] args){
            Car car = new Car();
            Bike bike = new Bike();
            Van van = new Van();
            car.Go();
            bike.Go();
            van.Go();
        }
    }
    interface ITwoWheeler{
        void Go();  
    }
    interface IFourWheeler{
        void Go();
    }
    class Car : IFourWheeler{
        public void Go(){
            Console.WriteLine("The vehicle is moving with 4 wheels.");
        }
    }
    class Bike : ITwoWheeler{
        public void Go(){
        Console.WriteLine("The vehicle is moving with 2 wheels.");
        }
    }
    class Van : IFourWheeler{
        public void Go(){
        Console.WriteLine("The vehicle is moving with 4 wheels.");
        }
    }
}