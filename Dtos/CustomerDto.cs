using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace AutoMapperApp.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string EmailAge { get; set; } //automapping a method and a property 



        // Flattening --> One of the common usages of object-object mapping is to take a complex object model and flatten it to a simpler model.
        public string CreditCardNumber { get; set; } // public + Number Return Type + Class Name + Property Name
        public DateTime CreditCardValidDate { get; set; } // public + ValidDate Return Type + Class Name + Property Name


    }
}
