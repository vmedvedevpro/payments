using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Payments.Infrastructure.Persistence.Configuration.Base;

namespace Payments.Infrastructure.Persistence.Configuration;

public class CurrencyGroupConfiguration : EntityBaseConfigurationBase<CurrencyGroup>
{
    public override void Configure(EntityTypeBuilder<CurrencyGroup> builder)
    {
        builder.HasMany(x => x.Currencies).WithMany();
        builder.HasIndex(x => x.Name).IsUnique();
        base.Configure(builder);
    }
}
