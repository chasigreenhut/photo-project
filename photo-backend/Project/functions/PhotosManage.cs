using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.functions
{
    public class PhotosManage
    {
        public static void Add(Photos pakage)
        {
            Data.DB.Photos.Add(pakage);
            Data.DB.SaveChanges();
        }
        /*public static void Delete(Photos pakage)
        {

            pakages pacage = Data.DB.Photos.Where(p => p. == pakage.pacageId).First();
            Data.DB.Photos.Remove(pacage);
            Data.DB.SaveChanges();
        }*/
       /* public static void Update(Photos pakage)
        {
            Project.Photos oldPakage = Data.DB.Photos.Where(p => p.pacageId == pakage.pacageId).First();
            Data.DB.pakages.Remove(pakage);
            Data.DB.pakages.Add(pakage);
            Data.DB.SaveChanges();

        }
        public static void getAll(pakages pakage)
        {

        }*/

        //public static void getAll(Users user)
        //{

        //}
    }
}