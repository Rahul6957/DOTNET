namespace products.models;

using System;

public class Product
{
    
    public int id{get; set;}
    public string Name{get;set;}
    public int price{get ;set;}

    public Product(int id,string Name,int price)
    {
        this.id=id;
        this.Name=Name;
        this.price=price;
    }
    
}