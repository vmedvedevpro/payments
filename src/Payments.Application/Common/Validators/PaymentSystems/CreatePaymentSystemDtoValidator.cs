using FluentValidation;

using Payments.Application.PaymentSystems.Commands.CreatePaymentSystem;

namespace Payments.Application.Common.Validators.PaymentSystems;

public class CreatePaymentSystemDtoValidator : AbstractValidator<CreatePaymentSystemDto>
{
    public CreatePaymentSystemDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
        RuleFor(x => x.Description).NotEmpty().MaximumLength(200);
    }
}
