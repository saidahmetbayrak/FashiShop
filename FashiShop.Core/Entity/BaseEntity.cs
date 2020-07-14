using System;
using System.ComponentModel.DataAnnotations;

namespace FashiShop.Core.Entity
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreateDate=DateTime.Now;
            IsActive=false;
        }
        public int ID { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
    }
}