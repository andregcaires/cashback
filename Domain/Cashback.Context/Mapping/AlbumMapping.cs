using Cashback.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Cashback.Context.Mapping
{
    public class AlbumMapping : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.MusicStyle).IsRequired();

            builder.Property(b => b.Price)
                .HasColumnType("money")
                .IsRequired();
        }
    }
}
