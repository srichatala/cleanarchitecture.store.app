using AutoMapper;
using MediatR;
using Store.Application.Common;
using Store.Application.Common.Interfaces;
using Store.Application.Shops.Queries;
using Store.Application.Shops.Response;
using System.Threading;
using System.Threading.Tasks;

namespace Store.Application.Shop.Handlers
{
    public class GetShopByIdHandler : IRequestHandler<GetShopByIdQuery, ShopResponse>
    {
        private readonly IStoreContext _context;
        private readonly IMapper _mapper;
        public GetShopByIdHandler(IStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ShopResponse> Handle(GetShopByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Shop.FindAsync(request.Id);
            if (entity == null)
            {
                throw new NotFoundException(nameof(ShopResponse), request.Id);
            }
            return _mapper.Map<ShopResponse>(entity);
        }
    }
}
