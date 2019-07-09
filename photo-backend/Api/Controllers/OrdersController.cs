using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PhotoApi.Controllers
{
   // [RoutePrefix("api/orders")]
    public class OrdersController : ApiController
    {
        
        //[Route("GetOrders")]
        public List<Order> GetOrders()
        {
            var user = new User("Elisheva", "Epstein", "eli7green@gmail.com");
            var order = new Order(DateTime.Now,user);
            var lst= new List<Order> { order } ;
            return lst;

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
