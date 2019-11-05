using Microsoft.EntityFrameworkCore;
using Cashback.Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cashback.Context.Mapping
{
    class CashbackMapping : IEntityTypeConfiguration<CashbackByDayOfWeek>
    {
        public void Configure(EntityTypeBuilder<CashbackByDayOfWeek> builder)
        {

        }
    }
}
