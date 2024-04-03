using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Payments.Domain.Entities.Base;

namespace Payments.Infrastructure.Persistence.Configuration.Base;

public class EntityBaseConfigurationBase<T> : IEntityTypeConfiguration<T>
    where T : EntityBase
{
    public virtual void Configure(EntityTypeBuilder<T> builder) => builder.HasKey(x => x.Id);
}
