using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.functions
{
    public class UsersManage
    {


        public static void add(Users user)
        {
            Data.DB.Users.Add(user);
            Data.DB.SaveChanges();
        }

        public static void update(Users user)
        {
            Users oldUser = Data.DB.Users.Where(u => u.userId == user.userId).First();
            Data.DB.Users.Remove(oldUser);
            Data.DB.Users.Add(oldUser);
            Data.DB.SaveChanges();
        }
        public void Delete(Users user)
        {
            Users user1 = Data.DB.Users.Where(u => u.userId == user.userId).First();
            Data.DB.Users.Remove(user1);
            Data.DB.SaveChanges();
        }
        //public static void getAll(Users user)
        //{

        //}

        //public static Users getUserByNameAndPassword(string mail, string password)
        //{

        //}
    }
}