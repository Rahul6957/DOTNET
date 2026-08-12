using  Catalog;
var builder = WebApplication.CreateBuilder(args); //instance of WebApplication Builder
var app = builder.Build(); //instance of WebApplication
//api endpoint url(action) -----------callback function (handler)
app.MapGet("/api/customers", () =>{return  "tanvi, nikita, sachin";});
app.MapGet("/api/cart", () =>{return  "laptop-2, samsung-6, earbuds-8";});
app.MapGet("/api/orders", () =>{return  "ord123, ord432, ord987";});
app.MapGet("/api/products", () =>{return ProdutService.GetAll();});
app.MapPost("/api/products",()=>{ return ProdutService.Insert();});
app.Run();