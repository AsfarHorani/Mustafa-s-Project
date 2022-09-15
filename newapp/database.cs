using System;
using MySql.Data.MySqlClient;

namespace newapp
{

class Database{
     
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

         public Database(){
                Initialize();            
         }

 //Initialize values
    private void Initialize()
    {
        server = "localhost";
        database = "task1";
        uid = "root";
        password = "Constantinople.7";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }

//open connection to database
private bool OpenConnection()
{
    try
    {
        connection.Open();
        return true;
    }
    catch (MySqlException ex)
    {
        //When handling errors, you can your application's response based 
        Console.WriteLine(ex.Message);
        return false;
    }
}

//Close connection
private bool CloseConnection()
{
    try
    {
        connection.Close();
        return true;
    }
    catch (MySqlException ex)
    {
        Console.WriteLine(ex.Message);
        return false;
    }
}
}




}