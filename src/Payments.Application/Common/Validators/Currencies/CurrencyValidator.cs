using FluentValidation;

namespace Payments.Application.Common.Validators.Currencies;

public class CurrencyValidator : AbstractValidator<Currency>
{
    public CurrencyValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
        RuleFor(x => x.Id).NotEmpty();
    }
}
