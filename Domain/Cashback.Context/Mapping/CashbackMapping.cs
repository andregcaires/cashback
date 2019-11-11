using Microsoft.EntityFrameworkCore;
using Cashback.Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cashback.Context.Mapping
{
    class CashbackMapping : IEntityTypeConfiguration<CashbackByDayOfWeek>
    {
        public void Configure(EntityTypeBuilder<CashbackByDayOfWeek> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(b => b.DayOfWeek).IsRequired();
            builder.Property(b => b.MusicStyle).IsRequired();
            builder.Property(b => b.Percentage).IsRequired();
        }
    }
}
