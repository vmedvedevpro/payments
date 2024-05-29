using AutoMapper;

using Payments.Application.CurrencyGroups.Commands.CreateCurrencyGroup;

namespace Payments.Application.Common.MapProfiles;

public class CreateCurrencyGroupDto2CurrencyGroup : Profile
{
    public CreateCurrencyGroupDto2CurrencyGroup() =>
        CreateMap<CreateCurrencyGroupDto, CurrencyGroup>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.Currencies, o => o.Ignore());
}
