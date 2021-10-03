using Microsoft.EntityFrameworkCore;
using Store.Application.Common.Interfaces;
using Store.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Store.Infrastructure.Data
{
    public class StoreContext : DbContext, IStoreContext
    {
        public StoreContext(DbContextOptions options) : base(options) { }

        public DbSet<ShopEntity> Shop { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var result = await base.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
