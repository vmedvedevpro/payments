using AutoMapper;

using Payments.Application.PaymentSystems.Commands.CreatePaymentSystem;

namespace Payments.Application.Common.MapProfiles;

public class CreatePaymentSystemDto2PaymentSystem : Profile
{
    public CreatePaymentSystemDto2PaymentSystem() =>
        CreateMap<CreatePaymentSystemDto, PaymentSystem>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.Currencies, o => o.Ignore())
            .ForMember(d => d.Payments, o => o.Ignore());
}
