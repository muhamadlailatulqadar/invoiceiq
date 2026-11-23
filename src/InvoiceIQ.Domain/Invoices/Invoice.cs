namespace InvoiceIQ.Domain.Invoices;

public class Invoice
{
    public Guid Id { get; private set; }
    public string OriginalFileName { get; private set; } = string.Empty;
    public InvoiceStatus Status { get; private set; }
    public DateTimeOffset UploadedAt { get; private set; }

    // EF Core uses this when it loads an invoice from the database.
    private Invoice() { }

    public static Invoice Upload(string originalFileName, DateTimeOffset uploadedAt)
    {
        if (string.IsNullOrWhiteSpace(originalFileName))
        {
            throw new ArgumentException("A file name is required.", nameof(originalFileName));
        }

        return new Invoice
        {
            Id = Guid.NewGuid(),
            OriginalFileName = originalFileName,
            Status = InvoiceStatus.Queued,
            UploadedAt = uploadedAt
        };
    }
}