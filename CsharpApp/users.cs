using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpApp
{
    public class users
    {
        private string[,] userslist = new string[3, 2]{
        { "admin","232"},
        {"abd","123" },
        {"ali","000" }
        };

        public string username { get; set; }
        public string password { get; set; }

        public  string login()
        {
            bool auth = false;
            if (username == null || password == null)
            {
                auth = false; 
            }
            else {
                for (int i = 0; i < 3; i++) //rows
                {
                    
                        if (username == userslist[i, 0] && password == (userslist[i, 1]))
                        auth = true;
                        else
                        auth = false;
                    
                }
            }
            if(auth == true)
                 return ("you've sigined in succesfuly");
            else 
                return ("invalid username or password");

            ///Console.WriteLine(auth ? "" : "");

        }
    }
}
