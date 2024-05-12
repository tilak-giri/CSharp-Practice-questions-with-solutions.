namespace MyNameSpace{
    class Program{
        static void Main(string[] args){
            Bike bike1 = new Bike(200);

            bike1.Speed = 10000000;

            Console.WriteLine(bike1.speed);
        }
    }
    class Bike{
        public int speed;
        public Bike(int speed){
            Speed = speed;
        }

        public int Speed{
            get { return speed; }  //read the speed
            set{
                if (value > 299){
                    speed = 299;
                }
                else{
                    speed = value;
                }
            }
        }
    }
}