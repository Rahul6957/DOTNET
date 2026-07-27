namespace Catalog;
using System.Collections.Generic;
using Entities;

public class ProdutService
{
    public static List<Product> GetAll()
    {
        List<Product> products=new List<Product>();
        products.Add(new Product{ Id=23, Title="Gerbera", Price=78.8});
        products.Add(new Product{ Id=23, Title="Rose", Price=8.8});
        products.Add(new Product{ Id=23, Title="Tulip", Price=3.8});
        products.Add(new Product{ Id=23, Title="Carntia", Price=7.6});
        return products;
    }

    public static string  Insert()
    {
        Console.WriteLine("New product inserttion process");
        return "product inserted successfully";
    }
}