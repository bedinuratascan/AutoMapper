using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime? BirthDay { get; set; }
        public IList<Address> Addresses { get; set; }
        public Gender Gender { get; set; }
        public  CreditCard CreditCard { get; set; } //flattening

        //automapping a method and a property
        public string GetEmailAge()
        {
            return $"{Email}-{Age}";
        }

        // mapping different method name and property name
        public string EmailAge()
        {
            return $"{Email}-{Age}";
        }

    }
     
}
