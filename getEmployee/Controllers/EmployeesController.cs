using Emp;
using Microsoft.AspNetCore.Mvc;

namespace empController;

public class EmployeesController:Controller
{

List<Employee> emp1=new List<Employee>
{
    new(1,"Rahul",60000000),
    new(2,"Ram",4000000),
    new(3,"kunal",500000)
};
    
    public IActionResult GetEmployees()
    {
        return View(emp1);
    }
}