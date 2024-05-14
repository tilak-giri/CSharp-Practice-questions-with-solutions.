namespace MyFirstProgram{
    class Program{        
        static void Main(string[] args){
            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine("planet: " + name);
            Console.WriteLine("radius: " + radius +"km");
            Console.WriteLine("volume: " + volume +"km^3");
        }
        public static double Volume(PlanetRadius radius){
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }
    enum PlanetRadius{
        Mercury = 2440,
        Venus = 6052,
        Earth = 6371,
        Mars = 3390,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
    }
}