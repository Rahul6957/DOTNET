using Transflower.Entities;
namespace EmployeeManagementservice;

public static class EmployeeService

{
    private static List<EmployeeManagement> employee=new()
    {
        new EmployeeManagement
        {
            Id = 1,
            Name = "Rahul",
            Department = "IT",
            Salary = 45000 
        },

             new EmployeeManagement
        {
            Id = 2,
            Name = "sachin",
            Department = "HR",
            Salary = 35000
        },

        new EmployeeManagement
        {
            Id = 3,
            Name = "Nitish",
            Department = "Finance",
            Salary = 50000
        }
    
    };

//Get API
public static async Task<List<EmployeeManagement>>GetEmployees()
    {
       await Task.Delay(500);

       return employee;
        
    }


//POST API

public static async Task AddEmployee(EmployeeManagement employees)
    {
        await Task.Delay(500);
    employee. Add(employees);
    }



//update 

public static async Task<bool> UpdateEmployee(EmployeeManagement employees)
    {
        await Task.Delay(500);
EmployeeManagement? emp =EmployeeManagement.FirstOrDefault(e=> e.id == employees.Id );
 if (emp == null)
            return false;

    emp.Name =employees.Name;
    emp.Department= employees.Department;
    emp.Salary=employees.Salary;

    return true;

    }

}