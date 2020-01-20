using System;
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

        public static List<Orders> getOrderByUser(int id)
        {
            List<Orders> ListOrders = db.Orders.Where(o => o.userId == id).ToList();
            return ListOrders;
        }

        public static int UploadPhotosToOrder(List<Photos> photos)
        {
            photos.ForEach(photo => db.Photos.Add(photo));
            var result = db.SaveChanges();
            return result;
        }
    }
}
