// using System;
// using MySql.Data.MySqlClient;

// namespace newapp
// {

// class Database{
     
//     private MySqlConnection connection;
//     private string server;
//     private string database;
//     private string uid;
//     private string password;

//          public Database(){
//                 Initialize();            
//          }

//  //Initialize values
//     private void Initialize()
//     {
//         server = "localhost";
//         database = "task1";
//         uid = "root";
//         password = "Constantinople.7";
//         string connectionString;
//         connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

//         connection = new MySqlConnection(connectionString);
//     }

// //open connection to database
// public bool OpenConnection()
// {
//     try
//     {
//         connection.Open();
//         return true;
//     }
//     catch (MySqlException ex)
//     {
//         //When handling errors, you can your application's response based 
        
//         Console.WriteLine(ex.Message);
//         return false;
//     }
// }

// //Close connection
// public bool CloseConnection()
// {
//     try
//     {
//         connection.Close();
//         return true;
//     }
//     catch (MySqlException ex)
//     {
//         Console.WriteLine(ex.Message);
//         return false;
//     }
// }
//  //Insert statement
//     public void Insert()
//     {
//     }

//     //Update statement
//     public void excecuteQueryIDU(string q)
//     {
//         if(this.OpenConnection()){
//         MySqlCommand cmd = new MySqlCommand();
//         //Assign the query using CommandText
//         cmd.CommandText = q;
//         //Assign the connection using Connection
//         cmd.Connection = connection;
       
//        //Execute query
//         cmd.ExecuteNonQuery();

//         //close connection
//         this.CloseConnection();
//         }
//     }

//     //Select statement
//     public List< string >[] excecuteQuerySelect(stirng q)
//     {
//             List< string > list = new List<string>;

//      if(this.OpenConnection()){
//         MySqlCommand cmd = new MySqlCommand(q, connection);
//         //Create a data reader and Execute the command
//         MySqlDataReader dataReader = cmd.ExecuteReader();
//     //Read the data and store them in the list
//        int i=0;
//         while (dataReader.Read())
//         {
//             string row ="";
//              for(int i=0; i<dataReader.FieldCount; i++){
//                 row+=dataReader[i];
//              }


//         }

//         //close connection
//         this.CloseConnection();
//         } 
//     }

//     //Count statement
//     public int Count()
//     {
//     }

//     //Backup
//     public void Backup()
//     {
//     }

//     //Restore
//     public void Restore()
//     {
//     }



// }




// }