using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class OrderHeader
    {
        public OrderHeader()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public long OrderTotal { get; set; }
        public string TrackingNumber { get; set; }
        public string Carrier { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public string TransactionId { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string Village { get; set; }
        public string District { get; set; }
        public string City { get; set; }

        public virtual AspNetUser ApplicationUser { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
