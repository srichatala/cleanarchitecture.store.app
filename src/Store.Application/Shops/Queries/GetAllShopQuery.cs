using MediatR;
using Store.Application.Common.Models;
using Store.Application.Shops.Response;

namespace Store.Application.Shops.Queries
{
    public record GetAllShopQuery : IRequest<PaginatedList<ShopResponse>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
