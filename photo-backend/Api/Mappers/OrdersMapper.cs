using Api.Models;
using Model;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Mappers
{
    public class OrdersMapper
    {
        public Models.Order MapToClientOrder(Orders DbOrder)
        {
            if (DbOrder == null)
                return null;
            return new Models.Order
            {
                userId = DbOrder.userId,
                dateOrder = DbOrder.dateOrder,
                numberOfOurs = DbOrder.numberOfOurs,
                orderId = DbOrder.orderId,
                pacageId = DbOrder.pacageId,
                Publishable = DbOrder.Publishable

            };
        }

        public Photos MapToDbPhoto(Models.Photo clientPhoto, int orderId)
        {
            if (clientPhoto == null)
                return null;
            return new Photos
            {
                orderId = orderId,
                photoUrl = clientPhoto.photoUrl,
                selected = clientPhoto.selected
            };
        }
    }
}