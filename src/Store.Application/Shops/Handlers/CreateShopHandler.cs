using AutoMapper;
using MediatR;
using Store.Application.Common;
using Store.Application.Common.Interfaces;
using Store.Application.Shops.Commands;
using Store.Application.Shops.Response;
using Store.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Store.Application.Shops.Handlers
{
    public class CreateShopHandler : IRequestHandler<CreateShopCommand, ShopResponse>
    {
        private readonly IStoreContext _context;
        private IMapper _mapper;

        public CreateShopHandler(IStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ShopResponse> Handle(CreateShopCommand req, CancellationToken cancellationToken)
        {
            var shopEntity = _mapper.Map<ShopEntity>(req);
            if (shopEntity is null)
            {
                throw new NotFoundException(nameof(ShopEntity), req);
            }

            _context.Shop.Add(shopEntity);
            await _context.SaveChangesAsync(cancellationToken);
            return _mapper.Map<ShopResponse>(shopEntity);
        }
    }
}
