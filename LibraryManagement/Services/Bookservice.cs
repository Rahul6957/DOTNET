namespace BookServices;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;
using sq;

public class BooksService
{
    private static List<Books> books =new List<Books>()
    {
        new Books{ bookId=1,Title="python",Price=700},
        new Books{ bookId=2,Title="C#",Price=70},
         new Books{ bookId=3,Title="C",Price=745},
        
    };

    //it method show all books
    public static List<Books> GetBook()
    {
      return books;  
    }
    

//this method add book 
     public static void InsertBook(Books book)
    {
        
     books.Add(book);
     

    }



public static void UpdateBook(int id,string Title)
    {
        foreach (Books b in books )

        {
            if 
            
        }
    }





}