using System.Collections.Generic;
using FashiShop.BLL.Abstract;
using FashiShop.DAL.Abstract;
using FashiShop.Model;

namespace FashiShop.BLL.Concrete
{
    public class UserService : IUserService
    {
        IUserDAL _user;
        public UserService(IUserDAL user)
        {
            _user = user;
        }

        public ICollection<User> CheckUser(string username, string mail)
        {
            try
            {
                if(username != null && mail != null){
                    
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return _user.GetAll(a => a.UserName == username && a.Email == mail || a.UserName==username || a.Email==mail );
        }

        public void Remove(User entity)
        {
            _user.Delete(entity);
        }

        public ICollection<User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public User GetById(int entityID)
        {
            throw new System.NotImplementedException();
        }

        public User GetUserByLogin(string email, string password)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(User entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new System.NotImplementedException();
        }
    }
}