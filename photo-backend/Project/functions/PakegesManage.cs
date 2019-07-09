using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.functions
{
    public class PakegesManage
    {
        public static void Add(pakages pakage)
        {
            Data.DB.pakages.Add(pakage);
            Data.DB.SaveChanges();
        }
        public static void Delete(pakages pakage)
        {

            pakages pacage = Data.DB.pakages.Where(p => p.pacageId ==pakage.pacageId).First();
            Data.DB.pakages.Remove(pacage);
            Data.DB.SaveChanges();
        }
        public static void Update(pakages pakage)
        {
             Project.pakages oldPakage = Data.DB.pakages.Where(p => p.pacageId== pakage.pacageId).First();
            Data.DB.pakages.Remove(pakage);
            Data.DB.pakages.Add(pakage);
            Data.DB.SaveChanges();

        }
        public static void getAll(pakages pakage)
        {

        }
    }
}