namespace sR;

using Microsoft.AspNetCore.Mvc;
using student.Models;


public class studentCotroller : Controller
{
    List<Student> s1=new List<Student>
    {
        new Student(1,"Rahul","GvH",12),
        new Student(2,"Kunal","KBS",4),
        new Student(3,"shrdha","SSK",4)


    };

    public IActionResult GetStudent()
    {
        return View(s1);
        
    }

}