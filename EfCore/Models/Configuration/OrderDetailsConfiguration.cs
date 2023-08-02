using EfCore.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Models.Configuration
{
    public class OrderDetailsConfiguration : BaseConfiguration<OrderDetails>
    {
        public override void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });
        }
    }
}
