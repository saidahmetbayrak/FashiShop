using System;
using System.Collections.Generic;
using FashiShop.Core.Entity;

namespace FashiShop.Model
{
    public class Category:BaseEntity
    {
    
        public string CategoryName { get; set; }

        //Mapping
        public virtual List<Product> Products { get; set; }
    }
}
