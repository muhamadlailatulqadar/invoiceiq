using InvoiceIQ.Domain.Invoices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceIQ.Infrastructure.Persistence.Configurations;

public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.ToTable("Invoices");
        builder.HasKey(invoice => invoice.Id);

        builder.Property(invoice => invoice.OriginalFileName)
            .HasMaxLength(260)
            .IsRequired();

        builder.Property(invoice => invoice.Status)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.HasIndex(invoice => invoice.Status);
    }
}