// class Program{
//     public static void Main(string[] args){
//         Car car1 = new Car("Mustang", "Green");
//         ChangeColor(car1, "Red");
//         Console.WriteLine($"The {car1.model} should always be {car1.color}.");
//     }
//     public static void ChangeColor(Car car, string color)
//     {
//         car.color = color;
//     }
//     public class Car{
//         public string model;
//         public string color;

//         public Car(string model, string color){
//             this.model = model;
//             this.color = color;
//         }
//     }
// }

class Program{
    public static void Main(string[] args){
        Car car1 = new Car("Mustang", "Red");

        Car car2 = Copy(car1);

        Console.WriteLine($"{car2.model} in {car2.color}");
        Console.WriteLine($"{car1.model} in {car1.color}");
    }
    public static Car Copy(Car car)
    {
        return new Car(car.model, car.color);
    }
}
public class Car{
        public string model;
        public string color;

        public Car(string model, string color){
            this.model = model;
            this.color = color;
        }
    }