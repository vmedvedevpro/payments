using AutoMapper;

using Payments.Application.CurrencyGroups.Commands.CreateCurrencyGroup;

namespace Payments.Application.Common.MapProfiles;

public class CreateCurrencyGroupDto2CurrencyGroup : Profile
{
    public CreateCurrencyGroupDto2CurrencyGroup() =>
        CreateMap<CreateCurrencyGroupDto, CurrencyGroup>()
            .ForMember(d => d.Name, o => o.MapFrom(s => s.Name));
}
