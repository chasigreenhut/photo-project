using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Photo
    {
        public int orderId { get; set; }
        public string photoUrl { get; set; }
        public bool? selected { get; set; }

    }
}