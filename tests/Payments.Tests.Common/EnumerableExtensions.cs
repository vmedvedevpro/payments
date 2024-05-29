using Microsoft.EntityFrameworkCore;

using MockQueryable.NSubstitute;

namespace Payments.Tests.Common;

public static class EnumerableExtensions
{
    public static DbSet<TDomain> AsEfQueryable<TDomain>(this IEnumerable<TDomain> value)
        where TDomain : class =>
        value.AsQueryable().BuildMockDbSet();
}
