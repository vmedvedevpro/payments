using AutoMapper;

using Payments.Application.Payments.Commands.CreatePayment;

namespace Payments.Application.Common.MapProfiles;

public class CreatePaymentDto2Payment : Profile
{
    public CreatePaymentDto2Payment() =>
        CreateMap<CreatePaymentDto, Payment>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.Status, o => o.Ignore())
            .ForMember(d => d.Currency, o => o.Ignore());
}
