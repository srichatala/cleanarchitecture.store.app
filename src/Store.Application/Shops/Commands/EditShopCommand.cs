using MediatR;
using Store.Application.Shops.Response;
using System;

namespace Store.Application.Shops.Commands
{
    public class EditShopCommand : IRequest<ShopResponse>
    {
        public Int64 Id { get; set; }
        public string ShopName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}
