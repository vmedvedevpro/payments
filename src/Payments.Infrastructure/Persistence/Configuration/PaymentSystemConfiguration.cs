using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Payments.Infrastructure.Persistence.Configuration.Base;

namespace Payments.Infrastructure.Persistence.Configuration;

public class PaymentSystemConfiguration : EntityBaseConfigurationBase<PaymentSystem>
{
    public override void Configure(EntityTypeBuilder<PaymentSystem> builder)
    {
        builder.HasMany(x => x.Payments).WithOne(x => x.PaymentSystem);
        builder.HasMany(x => x.Currencies).WithMany();
        base.Configure(builder);
    }
}
