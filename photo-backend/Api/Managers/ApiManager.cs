using Api.Mappers;
using Api.Models;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Managers
{
    public class ApiManager

    {
        public OrdersMapper ordersMapper = new OrdersMapper();

        public List<Order> getOrderByUser(int id)
        {
            List<Orders> dbOrders = new List<Orders>();
            List<Order> orders = new List<Order>();

            dbOrders = MangerRepasitory.getOrderByUser(id);
            if(dbOrders != null)
            {
                dbOrders.ForEach(dbOrder =>
                {
                    orders.Add(ordersMapper.MapToClientOrder(dbOrder));
                });
            }
            return orders;



        }

        public int UploadPhotosToOrder(OrderPhotos orderPhotos)
        {
            if (orderPhotos == null || orderPhotos.photos.Count == 0)
                return 0;
            List<Photos> dbPhotos = new List<Photos>();
            orderPhotos.photos.ForEach((photoUrl) => {
                dbPhotos.Add(new Photos
                {
                    orderId = orderPhotos.orderId,
                    photoUrl = photoUrl

                });
             });
           return  MangerRepasitory.UploadPhotosToOrder(dbPhotos);
        }
    }
}