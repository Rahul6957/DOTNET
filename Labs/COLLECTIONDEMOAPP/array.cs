namespace array;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    // Constructor
    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;


    }
public void Display()
{
    Console.WriteLine($"Id: {Id}");
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"Price: {Price}");
}
    
}

