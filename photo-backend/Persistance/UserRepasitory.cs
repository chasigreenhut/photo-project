using Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public  class UserRepasitory 
    {
        
        public void Save(Users user)
        {
            
            Data.DB.Users.Add(user);
            Data.DB.SaveChanges();
        }

        public Users GetUser(string email,string password)
        {
            return Data.DB.Users.FirstOrDefault(u => u.emailAddress == email && u.userPassword == password);
        }

    }
}
