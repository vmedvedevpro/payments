using System.Reflection;

using AutoMapper;

namespace Payments.Application.Tests;

public class AutoMapperTests
{
    [Fact]
    public void MapConfigurationsIsValid() => new MapperConfiguration(x => x.AddMaps(Assembly.GetAssembly(typeof(DependencyInjection))))
        .AssertConfigurationIsValid();
}
