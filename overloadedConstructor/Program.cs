class Program{
    public static void Main(string[] args)
    {
        Momo momo1 = new Momo("chicken", "johl", "chatni");
        Momo momo2 = new Momo("veg", "fry");
        Momo momo3 = new Momo("chicken");
    }
}
class Momo
{
    string item;
    string type;
    string extra;
    public Momo(string item, string type, string extra)
    {
        this.item = item;
        this.type = type;
        this.extra = extra;
    }
    public Momo(string item, string type)
    {
        this.item = item;
        this.type = type;
    }
    public Momo(string item)
    {
        this.item = item;
    }
}