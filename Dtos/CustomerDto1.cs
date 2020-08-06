using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperApp.Dtos
{
    public class CustomerDto1
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Eposta { get; set; }
        public int Yas { get; set; }
        public string EpostaYas { get; set; } // mapping different method name and property name


        //Flatening
        public string KrediKartNumara { get; set; }
        public DateTime GecerlilikTarihi { get; set; }


        //using IncludeMembers()
        public string Number { get; set; }
        public DateTime ValidDate { get; set; }

    }
}
