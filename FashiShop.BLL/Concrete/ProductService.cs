using System.Linq;
using System.Collections.Generic;
using FashiShop.BLL.Abstract;
using FashiShop.DAL.Abstract;
using FashiShop.Model;
namespace FashiShop.BLL.Concrete
{
    public class ProductService : IProductService
    {
        IProductDAL _product;
        public ProductService(IProductDAL product)
        {
            _product = product;
        }
        public void Remove(Product entity)
        {
            var data = _product.GetById(a => a.ID == entity.ID);
            _product.Delete(data);
        }
        public ICollection<Product> GetAll()
        {
            return _product.GetAll();
        }

        public Product GetById(int entityID)
        {
            return _product.GetById(a => a.ID == entityID);
        }

        public void Insert(Product entity)
        {
           _product.Add(entity);
        }

        public void Update(Product entity)
        {
            _product.Update(entity);
        }

        public ICollection<Product> GetGenderProduct(int genderId)
        {
            return _product.GetAll(a => (int)a.ProductGender == genderId).ToList();
        }

        public ICollection<Product> GetCategoryOfProduct(int categoryId)
        {
            return _product.GetAll(a => a.CategoryID == categoryId).ToList();

        }

        public ICollection<Product> GetBrandOfProduct(int brandId)
        {
            return _product.GetAll(a => a.BrandId == brandId).ToList();
            
        }

        public ICollection<Product> GetSizeProduct(int sizeId)
        {
            return _product.GetAll(a => (int)a.ProductSize == sizeId).ToList();
            
        }

        public ICollection<Product> GetColorProduct(int colorId)
        {
            return _product.GetAll(a => (int)a.ProductColor == colorId).ToList();
            
        }
    }
}