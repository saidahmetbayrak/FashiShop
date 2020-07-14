using FashiShop.Core.DAL.EntityFramework;
using FashiShop.DAL.Abstract;
using FashiShop.Model;

namespace FashiShop.DAL.Concrete
{
    public class ProductRepository : EFRepositoryBase<Product, FashiShopDbContext>, IProductDAL
    {
        
    }
}