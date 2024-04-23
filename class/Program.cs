//this is my main class "Program"
class Program
{
    public static void Main(string[] args)
    {
        Message.Hello();
        Message.By();
    }
}
//here i have created a class named "Message" with two methods.
public static class Message
{
    public static void Hello()
    {
        Console.WriteLine("Hello Good Morning!");
    }
    public static void By()
    {
        Console.WriteLine("Tata!!!");
    }
}