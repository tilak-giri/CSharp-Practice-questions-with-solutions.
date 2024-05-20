namespace MyNameSpace{
    class Program{
        static void Main(string[] args){
            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();
        }
        public static void CountUp(){
            for (int i = 0; i<=10; i++){
                Console.WriteLine($"Thread I counting : {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("The countdown is over.");
        }
                public static void CountDown(){
                for (int i = 10; i>=0; i--){
                Console.WriteLine($"Thread II counting : {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("The countdown is over.");
        }
    }
}