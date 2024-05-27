using FluentValidation;

using Payments.Application.Common.Validators.Currencies;

namespace Payments.Application.Common.Validators.CurrencyGroups;

public class CurrencyGroupValidator : AbstractValidator<CurrencyGroup>
{
    public CurrencyGroupValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Name).NotEmpty();
        RuleForEach(x => x.Currencies).SetValidator(new CurrencyValidator());
    }
}
