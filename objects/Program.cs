class Program
{
    public static void Main(string[] args)
    {
        Human manxe = new Human();
        manxe.name = "Tilak Giri";
        manxe.age = 21;

        manxe.nam();
        manxe.umer();
    }
}
class Human
{
    public string name;
    public int age;

    public void nam()
    {
        Console.WriteLine($"My name is : {name}");
    }
    public void umer()
    {
        System.Console.WriteLine($"My age is : {age}");
    }
}