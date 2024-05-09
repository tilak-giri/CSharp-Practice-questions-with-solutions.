using System;
namespace MyNameSpace{
    class Program{
        static void Main(string[] args){
            Vehicle car = new Vehicle("Ford", "Mustang", 2022, "Red");
            Console.WriteLine(car);
        }
    }
    class Vehicle{
        public string make;
        public string model;
        public int year;
        public string color;
        public Vehicle(string make, string model, int year, string color){
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString() {
            return "The " + make + " " + model + " from " + year + " in " + color;
        }
    }
}