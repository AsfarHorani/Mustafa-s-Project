using System;

namespace app
{
    
    class Program
    {
        static void Main(string[] args)
        {
           

        }
    }


    class Person{
       public string name;
       public string age; 
       public string relation;
       private long phoneNo; 


    //    public long getPhoneNo(){
    //         // Console.WriteLine("What is yout age?");
    //         // string age = Console.ReadLine();
    //         // if(age==this.age)
    //         //     return phoneNo;

    //         return phoneNo;    
    //      }

    //     public void setPhoneNo(long n){
    //         this.phoneNo = n;
    //     }

    public string PhoneNo   // property
  {
    get {return phoneNo; }   // get method
    set { phoneNo = value; }  // set method
  }


        public Person(string _name, int _age, string _relation){
                this.name = _name;
                this.age = _age;
                this.relation = _relation;
        }

        public string toString(){
            return name+","+age+","+relation;
        }
    }
}
