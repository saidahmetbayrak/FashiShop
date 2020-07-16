using System;

using FashiShop.BLL.Abstract;
using FashiShop.BLL.Concrete;
using FashiShop.Core.DAL;
using FashiShop.Core.DAL.EntityFramework;
using FashiShop.DAL.Abstract;
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
            services.AddScoped(typeof(IBrandDAL), typeof(BrandRepository));
            services.AddScoped(typeof(ICategoryDAL), typeof(CategoryRepository));
            services.AddScoped(typeof(IOrderDAL), typeof(OrderRepository));
            services.AddScoped(typeof(IProductDAL), typeof(ProductRepository));
            services.AddScoped(typeof(IUserDAL), typeof(UserRepository));
            //services.AddScoped(typeof(IRepository<>), typeof(EFRepositoryBase<,>));

            /*
            services.AddDbContext<FashiShopDbContext>(options =>
            options.UseSqlServer("server=localhost; database=FashiShopDb; User Id=sa; Password=1Secure*Password1; MultipleActiveResultSets=True" ,x => x.MigrationsAssembly("FashiShop.DAL")));
            */
        }
    }
}