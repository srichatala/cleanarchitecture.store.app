using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Store.Application.Common.Interfaces;
using Store.Application.Common.Mapper;
using Store.Application.Common.Models;
using Store.Application.Shops.Queries;
using Store.Application.Shops.Response;
using System.Threading;
using System.Threading.Tasks;

namespace Store.Application.Shop.Handlers
{
    public class GetAllShopHandler : IRequestHandler<GetAllShopQuery, PaginatedList<ShopResponse>>
    {
        private readonly IStoreContext _context;
        private IMapper _mapper;

        public GetAllShopHandler(IStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<ShopResponse>> Handle(GetAllShopQuery request, CancellationToken cancellationToken)
        {
            return await _context.Shop.ProjectTo<ShopResponse>(_mapper.ConfigurationProvider)
                .PaginatedListAsync(request.PageNumber, request.PageSize);
        }
    }
}
