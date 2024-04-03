using AutoMapper;

using Payments.Application.PaymentSystems.Commands.CreatePaymentSystem;

namespace Payments.Application.Common.MapProfiles;

public class CreatePaymentSystemDto2PaymentSystem : Profile
{
    public CreatePaymentSystemDto2PaymentSystem() =>
        CreateMap<CreatePaymentSystemDto, PaymentSystem>()
            .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
            .ForMember(d => d.Description, o => o.MapFrom(s => s.Description));
}
