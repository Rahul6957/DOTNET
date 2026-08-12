using EmployeeManagementservice;
using Transflower.Entities;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/", () => "Hello World!");

app.MapGet("app/getemployees",async()=>{return await  EmployeeService.GetEmployees();});


app.MapPost("app/addEmployees", async (EmployeeManagement employee) =>
{
    await EmployeeService.AddEmployee(employee);

    return Results.Ok("Employee Added Successfully");
});

app.MapPut()
app.Run();

