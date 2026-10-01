using Microsoft.EntityFrameworkCore;
using UniteCorp.SharedKernel;

namespace UniteCorp.Persistence;

public sealed class EfUnitOfWork(AppDbContext dbContext) : IUnitOfWork
{
    public Task<int> CommitAsync(CancellationToken cancellationToken = default)
    {
        return dbContext.SaveChangesAsync(cancellationToken);
    }
}