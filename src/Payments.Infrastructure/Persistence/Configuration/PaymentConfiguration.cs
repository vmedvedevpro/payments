using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Payments.Infrastructure.Persistence.Configuration.Base;

namespace Payments.Infrastructure.Persistence.Configuration;

public class PaymentConfiguration : EntityBaseConfigurationBase<Payment>
{
    public override void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.Property(x => x.Status).HasConversion<string>();
        base.Configure(builder);
    }
}
