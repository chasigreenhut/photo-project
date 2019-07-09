using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
               
namespace Project.functions
{
    public class OrdersManage
    {
        private int orderId;

        public static void Add(Orders order)
        {
            Data.DB.Orders.Add(order);
            Data.DB.SaveChanges();
        }
        public static void Update(Orders order)
        {
            Orders oldOrder = Data.DB.Orders.Where(o => o.orderId == order.orderId).First();
            Data.DB.Orders.Remove(oldOrder);
            Data.DB.Orders.Add(oldOrder);
            Data.DB.SaveChanges();
        }
        public static void Delete(int id)
        {
            Orders order1 = Data.DB.Orders.Where(o => o.orderId == id).First();
            Data.DB.Orders.Remove(order1);
            Data.DB.SaveChanges();
        }
        public static List<Orders> getAll()
        {
            return Data.DB.Orders.ToList();
        }
    }
}