using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    internal class Users
    {
        


        
            public string username;
            public string password;


            public Users(string username, string password)
            {
                this.username = username;
                this.password = password;
            }

            public void Login()
            {
                if (username == "Cavid123" && password == "Cavid1993")
                {
                    Console.WriteLine("emeliyyat ugurludur");
                }
                else
                {
                    Console.WriteLine("Username ve ya password sehvdir");
                }
            }
        
    }

}
