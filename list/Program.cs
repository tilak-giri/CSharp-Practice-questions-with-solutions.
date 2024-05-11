namespace MyNameSpace{
    class Program{
        static void Main(string[] args){
            /*Declaring list*/
            List<string> food = new List<string>();

            food.Add("Momo");
            food.Add("Pizza");
            food.Add("Noodles");
            food.Add("Momo");
            food.Add("Chichken");
            food.Add("Mutton");

            food.Insert(1, "Dhikri");   /*to insert items in any index*/
            food.Remove("Noodles"); /*To remove items from list*/
            food.Sort(); /*Sorts the list in alphabetical order*/
            food.Reverse(); /*Reverse the list in alphabetical order*/
            Console.WriteLine(food.Count); /*To count the number of items in list*/
            Console.WriteLine(food.IndexOf("Noodles")); /*To find the first index of items*/
            Console.WriteLine(food.LastIndexOf("Momo")); /*To find last index of items*/
            Console.WriteLine(food.Contains("Mutton")); /*Gives the bool value*/
            String[] foodArray = food.ToArray(); /*converts list into array*/

            foreach(string foodItem in food){
                Console.WriteLine(foodItem);
            }

        }

    }
}