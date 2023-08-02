using EfCore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Models.Configuration
{

    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder) { 
    base.Configure(builder);
        builder.Property(x => x.UnitPrice) .HasColumnType("money");
    }
}
}
