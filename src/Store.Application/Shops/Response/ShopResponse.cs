using AutoMapper;
using Store.Application.Common.Mapper;
using Store.Domain.Entities;
using System;

namespace Store.Application.Shops.Response
{
    public class ShopResponse : IMapFrom<ShopEntity>
    {
        public Int64 Id { get; set; }
        public string ShopName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ShopEntity, ShopResponse>();
        }
    }
}
