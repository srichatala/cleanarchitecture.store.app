using AutoMapper;
using MediatR;
using Store.Application.Common;
using Store.Application.Common.Interfaces;
using Store.Application.Shops.Commands;
using Store.Application.Shops.Response;
using Store.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Store.Application.Shop.Handlers
{
    public class EditShopHandler : IRequestHandler<EditShopCommand, ShopResponse>
    {

        private readonly IStoreContext _context;
        private readonly IMapper _mapper;
        public EditShopHandler(IStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ShopResponse> Handle(EditShopCommand req, CancellationToken cancellationToken)
        {
            var entity = await _context.Shop.FindAsync(req.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(ShopEntity), req.Id);
            }

            entity.Id = req.Id;
            entity.ShopName = req.ShopName;
            entity.Phone = req.Phone;
            entity.Email = req.Email;
            entity.City = req.City;
            entity.State = req.State;
            entity.Street = req.Street;
            entity.PostalCode = req.PostalCode;

            await _context.SaveChangesAsync(cancellationToken);
            return _mapper.Map<ShopResponse>(entity);
        }
    }
}
