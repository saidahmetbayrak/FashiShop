using System;
using FashiShop.Core.Entity;

namespace FashiShop.Model
{
    public class OrderDetail
    {
        public OrderDetail()
        {
            Cancelled=false;
            Discount=0;
        }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }
        public bool Cancelled { get; set; }
        public string Note { get; set; }

        //Mapping
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
