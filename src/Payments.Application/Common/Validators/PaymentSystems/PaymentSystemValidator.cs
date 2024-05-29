using FluentValidation;

using Payments.Application.Common.Validators.Currencies;
using Payments.Application.Common.Validators.Payments;

namespace Payments.Application.Common.Validators.PaymentSystems;

public class PaymentSystemValidator : AbstractValidator<PaymentSystem>
{
    public PaymentSystemValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleForEach(x => x.Payments).SetValidator(new PaymentValidator());
        RuleForEach(x => x.Currencies).SetValidator(new CurrencyValidator());
        RuleFor(x => x.Description).MaximumLength(200);
        RuleFor(x => x.Name).MaximumLength(50);
    }
}
