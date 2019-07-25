using System;
using System.Linq;
using System.Web;



namespace Persistance
{
    public  class UserRepasitory 
    {
        
        public void Save(Users user)
        {
            try
            {
              
                Data.DB.Users.Add(user);
                Data.DB.SaveChanges();
            }
            catch (Exception ex)
            {

              
            }
            
           
        }


        public Users GetUser(string email,string password)
        {
            try
            {
                return Data.DB.Users.FirstOrDefault(u => u.emailAddress == email && u.userPassword == password);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

         }

    }
}
