using Dapper;
using DapperApp.Models;
using Microsoft.Data.SqlClient;

string connectionString = @"Server=localhost;Database=dapperdemodb;User=root;Password=password;";

var connection = new SqlConnection(connectionString);
connection.Open();
Console.WriteLine("Connected!");
string query = "SELECT * FROM Employees";
var employees = connection.Query<Employee>(query);
foreach (var employee in employees)
{
    Console.WriteLine(
        $"{employee.Id} - {employee.Name} - {employee.Email} - {employee.Salary}"
    );
}
