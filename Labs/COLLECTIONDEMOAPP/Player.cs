namespace WorldCup;

public class Player
{
    private int playerId {get;set;}
    private string name;
    private int jercyNo;
    private string position;
    private int age;

public Player(int playerId,string name,int jercyNo,string position,int age,string nationality,decimal salary)
    {
        PlayerId=playerId;
        Name = name;
        JerseyNumber = jercyNo;
        Position = position;
        Age = age;
        Nationality = nationality;
        Salary = salary;

    }




//Property
    public int PlayerId
    {
        get {return this.playerId;}
        set{this.playerId=value;}
    }

     //Auto Property
    public string Name { get; set; }
    public int JerseyNumber { get; set; }
    public string Position { get; set; }
    public int Age { get; set; }
    public string Nationality { get; set; }
    public decimal Salary { get; set; }
    
}