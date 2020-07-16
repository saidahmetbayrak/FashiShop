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
            return _user.GetAll(a => a.UserName == username && a.Email == mail || a.UserName==username || a.Email==mail );
        }

        public void Remove(User entity)
        {
            var data = _user.GetById(a => a.ID == entity.ID);
            _user.Delete(data);
        }

        public ICollection<User> GetAll()
        {
            return _user.GetAll();
        }

        public User GetById(int entityID)
        {
            return _user.GetById(a => a.ID == entityID);
        }

        public User GetUserByLogin(string email, string password)
        {
            return _user.GetById(a => a.Email == email && a.Password == password);
        }

        public void Insert(User entity)
        {
            _user.Add(entity);
        }

        public void Update(User entity)
        {
            _user.Update(entity);
        }
    }
}