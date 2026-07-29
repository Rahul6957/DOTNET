using BookServices;
using sq;
var builder = WebApplication.CreateBuilder(args); 
var app = builder.Build();
//get api
app.MapGet("/api/GETBooks",()=>{return BooksService.GetBook(); });

app.MapPost("/api/AddBooks", (Books book) =>{BooksService.InsertBook(book);return Results.Ok("Book Added Successfully");});
app.MapPut("/app/UpdateBook",(int id,string Title )=>{BooksService.UpdateBook( id,Title);return Results.Ok("Book Updated Successfully");});
app.Run();