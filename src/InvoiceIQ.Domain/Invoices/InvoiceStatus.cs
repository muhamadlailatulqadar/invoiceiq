namespace InvoiceIQ.Domain.Invoices;

public enum InvoiceStatus
{
    Queued,
    Extracting,
    NeedsReview,
    Approved,
    Rejected,
    Failed
}