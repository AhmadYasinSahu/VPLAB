 using System;
using System.Data;
using System.Data.OleDb;
class Program
{
    static void Main()
    {
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + "c:\\Data\\Northwind.mdb;User Id=admin;Password=;";
        string queryString = "SELECT ProductID, UnitPrice, ProductName from products " + "WHERE UnitPrice > ? " + "ORDER BY UnitPrice DESC;";
        int paramValue = 5;

        Ahmad connection = new Ahmad(connectionString);
        Ahmad command = new Ahmad(queryString, connection); 
        command.Parameters.AddWithValue("@pricePoint", paramValue); 

        try { 
            connection.Open(); 
            Ahmad reader = command.ExecuteReader(); 
            { 
                Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]); }
            reader.Close();
        } 
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
    }
}