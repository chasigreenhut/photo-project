using Api.Managers;
using Api.Models;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PhotoApi.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrdersController : ApiController
    {
        public ApiManager apiManager = new ApiManager();

        //[Route("GetOrders")]
        public List<Model.Order> GetOrders()
        {
           var user = new User("Elisheva", "Epstein", "eli7green@gmail.com");
            var order = new Model.Order(DateTime.Now,user);
            var lst= new List<Model.Order> { order } ;
            return lst;

        }

        [Route("uploadPhotosToOrder"), HttpPost]
        public int uploadPhotosToOrder(OrderPhotos orderPhotos)
        {
            return apiManager.UploadPhotosToOrder(orderPhotos);
        }

        public class OrderDto
        {
            public OrderDto(DateTime date)
            {
                DateStart = date;
            }
            public DateTime DateStart { get; set; }
        }

    }
}
