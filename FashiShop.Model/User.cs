using System.Linq;
using FashiShop.Core.Entity;
using System.Collections.Generic;

namespace FashiShop.Model
{
    public class User:BaseEntity
    {
        public User()
        {
            RoleId=Roles.User;
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles RoleId { get; set; }

        //Mapping
        public virtual List<Order> Orders { get; set; }
        public string EmailSplit(string mail){

            UserName=mail.Split('@').First();

            return UserName;
        }
    }
}

public enum Roles{
    User=1,
    Admin=2
}