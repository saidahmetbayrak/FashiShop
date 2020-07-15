using System;
using System.Collections.Generic;
using FashiShop.Core.Entity;

namespace FashiShop.Model
{
    public class Product:BaseEntity
    {
        public Product()
        {
             Discontinued=false;
        }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public int BrandId { get; set; }
        public short Stock { get; set; }
        public decimal Price { get; set; }
        public bool Discontinued { get; set; }
        public string ProductImgUrl { get; set; }
        public Color ProductColor { get; set; }
        public Size ProductSize { get; set; }
        public  Gender ProductGender{get; set;}

        //Mapping
        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}

public enum Color{
    Black=1,
    Blue=2,
    Red=3,
    Violet=4,
    Yellow=5,
    Green=6
}
public enum Size{
    XS=1,
    S=2,
    M=3,
    L=4,
    XL=5,
    XXL=6
}
public enum Gender{
Men = 1,
Women = 2,
Kids = 3

}