using AutoMapper;

using Payments.Application.Currencies.Commands.CreateCurrency;

namespace Payments.Application.Common.MapProfiles;

public class CreateCurrencyDto2Currency : Profile
{
    public CreateCurrencyDto2Currency() =>
        CreateMap<CreateCurrencyDto, Currency>()
            .ForMember(d => d.Name, o => o.MapFrom(s => s.Name));
}
