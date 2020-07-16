using System.Collections.Generic;
using FashiShop.Model;

namespace FashiShop.BLL.Abstract
{
    public interface IProductService : IBaseService<Product>
    {
         ICollection<Product> GetGenderProduct(int genderId);
         ICollection<Product> GetSizeProduct(int sizeId);
         ICollection<Product> GetColorProduct(int colorId);
         ICollection<Product> GetCategoryOfProduct(int categoryId);
         ICollection<Product> GetBrandOfProduct(int brandId);

    }
}