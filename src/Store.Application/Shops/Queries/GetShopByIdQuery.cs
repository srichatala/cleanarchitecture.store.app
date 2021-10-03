using MediatR;
using Store.Application.Shops.Response;
using System;

namespace Store.Application.Shops.Queries
{
    public class GetShopByIdQuery : IRequest<ShopResponse>
    {
        public Int64 Id { get; set; }
    }
}
