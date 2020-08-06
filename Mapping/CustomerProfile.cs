using AutoMapper;
using AutoMapperApp.Dtos;
using AutoMapperApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperApp.Mapping
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {
            //for the same property name
            CreateMap<Customer, CustomerDto>().ReverseMap();



            CreateMap<CreditCard, CustomerDto1>(); //for using includemembers()

            //for the different property name, method name
            CreateMap<Customer, CustomerDto1>().IncludeMembers(x=>x.CreditCard)
                .ForMember(dest => dest.Isim, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Eposta, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Yas, opt => opt.MapFrom(x => x.Age))
                .ForMember(dest => dest.EpostaYas, opt => opt.MapFrom(x => x.EmailAge()))
                .ForMember(dest => dest.KrediKartNumara, opt => opt.MapFrom(x => x.CreditCard.Number))
                .ForMember(dest => dest.GecerlilikTarihi, opt => opt.MapFrom(x => x.CreditCard.ValidDate));
                
        }
    }
}
