using FluentValidation;

using Payments.Application.Payments.Commands.CreatePayment;

namespace Payments.Application.Common.Validators.Payments;

public class CreatePaymentCommandValidator : AbstractValidator<CreatePaymentCommand>
{
    public CreatePaymentCommandValidator() => RuleFor(x => x.Payment).SetValidator(new CreatePaymentDtoValidator());
}
