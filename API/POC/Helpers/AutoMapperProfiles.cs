using AutoMapper;
using POC.DTOs;
using POC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Users, UsersDTO>().ReverseMap();

            CreateMap<UsersCreationDTO, Users>();

            CreateMap<ProductDetails, ProductDetailsDTO>().ReverseMap();

            CreateMap<Products, ProductsDTO>().ReverseMap();

            CreateMap<Orders, OrdersDTO>().ReverseMap();

            CreateMap<OrderItem, OrderItemDTO>().ReverseMap();

            CreateMap<Discount, DiscountDTO>().ReverseMap();

            CreateMap<Categories, CategoriesDTO>().ReverseMap();

            CreateMap<Cart, CartDTO>().ReverseMap();

            CreateMap<Address, AddressDTO>().ReverseMap();


        }

       
    }
}
