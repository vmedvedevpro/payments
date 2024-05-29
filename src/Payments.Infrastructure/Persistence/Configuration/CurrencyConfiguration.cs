using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Payments.Infrastructure.Persistence.Configuration.Base;

namespace Payments.Infrastructure.Persistence.Configuration;

public class CurrencyConfiguration : EntityBaseConfigurationBase<Currency>
{
    public override void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.HasIndex(x => x.Name).IsUnique();
        base.Configure(builder);
    }
}
