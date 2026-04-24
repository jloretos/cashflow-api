using Cashflow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cashflow.Infrastructure.Data;

public class CashflowDbContext : DbContext
{
    public CashflowDbContext(DbContextOptions<CashflowDbContext> options)
        : base(options)
    {
    }

    public DbSet<CashflowEntry> CashflowEntries => Set<CashflowEntry>();
}