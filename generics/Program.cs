using System;
namespace Name{
    class Program{
        static void Main(string[] args){
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringsArray = { "1", "2", "3" };

            displayData(intArray);
            displayData(doubleArray);
            displayData(stringsArray);
        }
        public static void displayData<T>(T[] integer){
            foreach (T i in integer){
                Console.WriteLine(i);
            }
        }
    }
}