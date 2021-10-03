using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Store.Application.Common.Interfaces
{
    public interface IStoreContext : IDisposable
    {
        DbSet<ShopEntity> Shop { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
