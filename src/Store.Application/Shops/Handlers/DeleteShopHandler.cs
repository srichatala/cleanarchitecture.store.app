using MediatR;
using Store.Application.Common;
using Store.Application.Common.Interfaces;
using Store.Application.Shops.Commands;
using Store.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Store.Application.Shop.Handlers
{
    public class DeleteShopHandler : IRequestHandler<DeleteShopCommand>
    {
        private readonly IStoreContext _context;
        public DeleteShopHandler(IStoreContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteShopCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Shop.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(ShopEntity), request.Id);
            }

            _context.Shop.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
