using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodBuy.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }

        [Display(Name = "Purchased (UTC)")]
        [DataType(DataType.DateTime)]
        public DateTimeOffset DatePurchasedUtc { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
    }
}