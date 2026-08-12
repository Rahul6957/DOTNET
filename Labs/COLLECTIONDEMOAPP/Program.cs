// namespace TFLCollections;
// using System.Collections.Generic;
// using WorldCup;
using array;
public class Program {

    public static void Main(string [] args)
    {
        // int [] goals =new int[] {4,6,8,1,3,0};
        // int currentMatchGoal=goals[2];

        // Team argentina=new Team();

        // string playerName=argentina[0].Name;
        // argentina[0].Name="Diyago Maradona";
        // playerName=argentina[0].Name;
        // Console.WriteLine( "Player ="+ playerName);
        // argentina.DisplayPlayers();

        // List<Player>  portugal=new List<Player>();
        // portugal.Add(new Player(1, "Cristiano Ronaldo", 7, "Forward", 41, "Portugal", 3000000m));
        // portugal.Add(new Player(2, "Bruno Fernandes", 8, "Midfielder", 32, "Portugal", 2200000m));
        // portugal.Add(new Player(3, "Bernardo Silva", 10, "Midfielder", 32, "Portugal", 2100000m));
        // portugal.Add(new Player(4, "Rafael Leao", 17, "Winger", 27, "Portugal", 2000000m));
        // portugal.Add(new Player(5, "Joao Felix", 11, "Forward", 27, "Portugal", 1800000m));
        // portugal.Add(new Player(6, "Ruben Dias", 3, "Defender", 30, "Portugal", 1900000m));
        // portugal.Add(new Player(7, "Pepe", 4, "Defender", 43, "Portugal", 900000m));
        // portugal.Add(new Player(8, "Joao Cancelo", 20, "Right Back", 33, "Portugal", 1700000m));
        // portugal.Add(new Player(9, "Nuno Mendes", 19, "Left Back", 24, "Portugal", 1600000m));
        // portugal.Add(new Player(10, "Vitinha", 23, "Midfielder", 27, "Portugal", 1500000m));
        // portugal.Add(new Player(11, "Diogo Costa", 1, "Goalkeeper", 28, "Portugal", 1400000m));

        // Player p1=portugal[2];
        // Console.WriteLine(p1.Name);


        Product[] products = new Product[5]
{
    new Product(101, "Mouse", 500),
    new Product(102, "Keyboard", 800),
    new Product(103, "Monitor", 7000),
    new Product(104, "Laptop", 55000),
    new Product(105, "Pen Drive", 700)
    
};
Console.WriteLine("helloo");
foreach (Product p in products)
{
    p.Display();
}

    }
}