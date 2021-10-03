using MediatR;
using Store.Application.Shops.Response;
using System;

namespace Store.Application.Shops.Commands
{
    public class CreateShopCommand : IRequest<ShopResponse>
    {
        public string ShopName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public DateTime CreatedDate { get; set; }

        public CreateShopCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
