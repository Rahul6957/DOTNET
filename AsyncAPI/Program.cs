using EmployeeManagementservice;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.MapGet("app/getemployees",async()=>{return await  EmployeeService.GetEmployees();});
app.Run();
