using Cashflow.Domain.Entities;
using Cashflow.Infrastructure.Data;

namespace Cashflow.Application.Services;

public class CashflowService
{
    private readonly CashflowDbContext _context;

    public CashflowService(CashflowDbContext context)
    {
        _context = context;
    }

    public void Add(CashflowEntry entry)
    {
        _context.CashflowEntries.Add(entry);
        _context.SaveChanges();
    }

    public IEnumerable<CashflowEntry> GetAll()
    {
        return _context.CashflowEntries.ToList();
    }
}