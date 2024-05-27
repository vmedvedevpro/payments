using FluentValidation;

using Payments.Application.Payments.Commands.CreatePayment;

namespace Payments.Application.Common.Validators.Payments;

public class CreatePaymentDtoValidator : AbstractValidator<CreatePaymentDto>
{
    public CreatePaymentDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Payment name is required");
        RuleFor(x => x.Amount).LessThanOrEqualTo(0).WithMessage("Payment amount cannot be negative or zero");
        RuleFor(x => x.CurrencyId).NotEmpty().WithMessage("Payment currency id is required");
        RuleFor(x => x.Description).MaximumLength(200).WithMessage("Payment description too long, maximum 200 characters");
    }
}
