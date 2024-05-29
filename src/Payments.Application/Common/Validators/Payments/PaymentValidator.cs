using FluentValidation;

namespace Payments.Application.Common.Validators.Payments;

public class PaymentValidator : AbstractValidator<Payment>
{
    public PaymentValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.CurrencyId).NotEmpty();
        RuleFor(x => x.Description).MaximumLength(200);
        RuleFor(x => x.Amount).GreaterThan(0);
    }
}
