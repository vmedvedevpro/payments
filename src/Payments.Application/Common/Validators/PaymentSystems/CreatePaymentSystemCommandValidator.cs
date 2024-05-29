using FluentValidation;

using Payments.Application.PaymentSystems.Commands.CreatePaymentSystem;

namespace Payments.Application.Common.Validators.PaymentSystems;

public class CreatePaymentSystemCommandValidator : AbstractValidator<CreatePaymentSystemCommand>
{
    public CreatePaymentSystemCommandValidator() => RuleFor(x => x.PaymentSystem).SetValidator(new CreatePaymentSystemDtoValidator());
}
