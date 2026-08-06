namespace product.Controllers;

using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using products.models;


public class ProductsController : Controller
{
    
List<Product>  products=new List<Product>()
{
    new Product(1,"Mouse",500),
    new Product(2,"Keybord",600),
    new Product(3,"Mobile",1500000)
};

public IActionResult GetProducts(){
        return View(products);
    }
















};
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
    //action method

    
