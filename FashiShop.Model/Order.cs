using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using FashiShop.Core.Entity;

namespace FashiShop.Model
{
    public class Order:BaseEntity
    {
        public int UserDetailID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }

        //Mapping
        public virtual User UserDetail { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
