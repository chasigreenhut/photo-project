using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public string pacageId { get; set; }
        public DateTime? dateOrder { get; set; }
        public int numberOfOurs { get; set; }
        public bool? Publishable { get; set; }
        public int userId { get; set; }

        //public virtual Photos Photos { get; set; }

    }
    public class OrderPhotos
    {
        public int orderId { get; set; }
        public List<string> photos { get; set; }
    }
}

