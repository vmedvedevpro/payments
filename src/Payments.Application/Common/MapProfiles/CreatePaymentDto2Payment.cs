using AutoMapper;

using Payments.Application.Payments.Commands.CreatePayment;

namespace Payments.Application.Common.MapProfiles;

public class CreatePaymentDto2Payment : Profile
{
    public CreatePaymentDto2Payment() =>
        CreateMap<CreatePaymentDto, Payment>()
            .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
            .ForMember(d => d.Description, o => o.MapFrom(s => s.Description))
            .ForMember(d => d.Amount, o => o.MapFrom(s => s.Amount))
            .ForMember(d => d.CurrencyId, o => o.MapFrom(s => s.CurrencyId));
}
