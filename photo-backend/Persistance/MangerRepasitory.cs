﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
   public static class MangerRepasitory
    {
        public static PhotoEndProjectEntities db = new PhotoEndProjectEntities();
       
       
        //שליפת כל המשתמשים
        public static List<Users> getAll()
        {
            List<Users> ListUsers = db.Users.ToList();
            return ListUsers;
        }
    }
}
