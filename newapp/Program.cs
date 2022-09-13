using System;
using MySql.Data.MySqlClient;

namespace newapp
{
    class Program
    {
        static void Main(string[] args)
        {
         string server = "localhost";
         string database = "task1";
         string uid = "root";
         string password = "Constantinople.7";
         string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn=new MySqlConnection(connectionString);
          
             try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                //SQL Query to execute
                //selecting only first 10 rows for demo
                string sql = "Describe doctor;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                //asdasda
                //adasd
                //asd
                //adasdasd

                //read the data
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2]);
                }
                rdr.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }


            Console.WriteLine("Hello World!");
        }
    }



    class User {

 
  //everything
  private string name;
  public string Name {
    get { return name; }  
    set { name = value; } 
  }
  private int age;
  public int Age {
    get { return age; }  
    set { age = value; } 
  }
  private string email;
  public string Email {
    get { return email; }   
    set { email = value; } 
  }
  private int phone;
  public int Phone {
    get { return phone; }  
    set { phone = value; } 
  }
  private string job;
  public string Job {
    get { return job; }   
    set { job = value; } 
  }

   //<empty>
   public User(){}
  
  //email
   public User(string _email){
     this.Email = _email;
   }
   public User(string _email, string _name, int _age, int _phone, string _job){
     this.Email = _email;
     this.Name = _name;
     this.Age = _age;
     this.Phone = _phone;
     this.Job = _job;
   }
   
}            

class Programmer : User {
  private int experience;
  public int Experience {
    get { return experience; }  
    set { experience = value; } 
  }
  private string programminglanguages;
  public string Programminglanguages {
    get { return programminglanguages; }  
    set { programminglanguages = value; } 
  }
  private string favouriteprogramminglanguage;
  public string Favouriteprogramminglanguage {
    get { return favouriteprogramminglanguage; }  
    set { favouriteprogramminglanguage = value; } 
  }
  private string achievements;
  public string Achievements {
    get { return achievements; }  
    set { achievements = value; } 
  }
}
}


