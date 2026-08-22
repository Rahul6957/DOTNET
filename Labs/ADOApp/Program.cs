using System;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
class Program
{
    static void Main()
    {
        string connectionString =
            "server=localhost;database=dapperdemodb;user=root;password=password;";

        MySqlConnection connection =
            new MySqlConnection(connectionString);

        try
        {
            connection.Open();

            Console.WriteLine("Connected to MySQL Successfully!");

 Console.Write("Enter ID: ");
            int Id=int.Parse(Console.ReadLine()) ;

            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string Email  = (Console.ReadLine());

            Console.Write("Enter Salary: ");
            int Salary =int.Parse(Console.ReadLine()) ;

            string query =
                "INSERT INTO employees(Id,Name, Email, Salary) " +
                "VALUES(@Id,@Name, @Email, @Salary)";

            MySqlCommand command =
                new MySqlCommand(query, connection);
 command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Salary", Salary);

            int rowsAffected = command.ExecuteNonQuery();

            Console.WriteLine(rowsAffected + " row inserted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Connection Closed.");
            }
        }
    }
}