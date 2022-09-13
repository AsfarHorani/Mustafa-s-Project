using System;
using MySql.Data.MySqlClient;

namespace newapp
{

class database{
      private  string server = "localhost";
       private  string database = "task1";
       private  string uid = "root";
       private  string password = "Constantinople.7";
       private  string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
       private MySqlConnection conn;

         public database(){
         conn = new MySqlConnection(connectionString);

         }

    //open connection to database
    private bool OpenConnection()
    {
        try{


        }catch(Exception ex){
            Console.WriteLine("We get an error");
        }
        conn.open();
    }

    //Close connection
    private bool CloseConnection()
    {
        conn.close();
    }
}




}