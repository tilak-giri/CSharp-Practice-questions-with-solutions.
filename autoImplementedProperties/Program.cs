namespace Name{
    class Program{
        static void Main(string[] args){
            Car car1 = new Car("mustang");
            Console.WriteLine(car1.Model);
        }
    }
    class Car{
        public string Model{ get; set; }
        public string model;
        public Car(string model){
            this.Model = model;
        }
    }
}