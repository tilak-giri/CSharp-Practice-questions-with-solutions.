namespace MyNameSpace{
    class Program{
        static void Main(string[] args){
            List<Player> players= new List<Player>();

            // Player player1 = new Player("Oggy");
            // Player player2 = new Player("Jack");
            // Player player3= new Player("Olivia");

            players.Add(new Player("Oggy"));
            players.Add(new Player("Jack"));
            players.Add(new Player("Olivia"));

            foreach(Player player in players){
                Console.WriteLine(player);
        }
    }
    class Player{
        public string userName;
        public Player(string userName){
            this.userName = userName;
        }
        public override string ToString(){
            return userName;
        } 
    }
}
}