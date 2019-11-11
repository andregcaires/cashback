using Cashback.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Context.Mapping
{
    public class SaleMapping : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(b => b.TotalCashback)
                .IsRequired()
                .HasColumnType("money");

            builder.Property(b => b.TotalValue)
                .IsRequired()
                .HasColumnType("money");

            builder.Property(b => b.PurchaseDay).IsRequired();

            builder.Property(b => b.PurchaseDate).IsRequired();

            builder.HasMany<SaleItem>(s => s.SaleItems)
                .WithOne(s => s.Sale)
                .HasForeignKey(s => s.SaleID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
