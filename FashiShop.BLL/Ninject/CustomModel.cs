using FashiShop.BLL.Abstract;
using FashiShop.BLL.Concrete;
using FashiShop.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FashiShop.BLL.Ninject
{
    public class CustomModel
    {
        public static void InjectDependencies(IServiceCollection services)
        {
            services.AddScoped<FashiShopDbContext>();
            services.AddScoped(typeof(IBrandService), typeof(BrandService));
            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            services.AddScoped(typeof(IOrderService), typeof(OrderService));
            services.AddScoped(typeof(IProductService), typeof(ProductService));
            services.AddScoped(typeof(IUserService), typeof(UserService));

            /*
            services.AddDbContext<FashiShopDbContext>(options =>
            options.UseSqlServer("server=localhost; database=FashiShopDb; User Id=sa; Password=1Secure*Password1; MultipleActiveResultSets=True" ,x => x.MigrationsAssembly("FashiShop.DAL")));
            */
        }
    }
}