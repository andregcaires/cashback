using Cashback.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Context.Mapping
{
    public class SaleItemMapping : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(b => b.CashbackUnitaryValue)
                .HasColumnType("money")
                .IsRequired();

            builder.Property(b => b.CashbackTotalValue)
                .HasColumnType("money")
                .IsRequired();

            builder.Property(b => b.UnitaryValue)
                .HasColumnType("money")
                .IsRequired();

            builder.Property(b => b.TotalValue)
                .HasColumnType("money")
                .IsRequired();
            
            builder.Property(b => b.Quantity)
                .IsRequired();

            builder.HasOne<Sale>(s => s.Sale)
                .WithMany(s => s.SaleItems)
                .IsRequired();

            builder.HasOne<Album>(s => s.Album)
                .WithOne();

        }
    }
}
