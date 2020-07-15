using System.Collections.Generic;
using FashiShop.Model;

namespace FashiShop.BLL.Abstract
{
    public interface IUserService : IBaseService<User>
    {
         User GetUserByLogin(string email,string password);
         ICollection<User> CheckUser(string username, string mail);
    }
}