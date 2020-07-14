using System;
using System.Collections.Generic;
using FashiShop.Core.Entity;

namespace FashiShop.Model
{
    public class Brand:BaseEntity
    {
        public string BrandName { get; set; }

        //Mapping
        public virtual List<Product> Products { get; set; }
    }
}
