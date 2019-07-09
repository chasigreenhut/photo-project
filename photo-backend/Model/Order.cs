using System;
using ModelAbstractions;

namespace Model
{
    public class Order : IOrder
    {
        public Order(DateTime dt,User user)
        {
            OrderDate = dt;
            User = user;
        }
        public DateTime OrderDate { get; set; }
        public User User { get; set; }
        public int NumberOfPeople { get; set; }
        
    }
}
