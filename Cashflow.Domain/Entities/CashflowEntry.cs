namespace Cashflow.Domain.Entities;

public class CashflowEntry
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; } = string.Empty; // credit / debit
    public string Description { get; set; } = string.Empty;
}