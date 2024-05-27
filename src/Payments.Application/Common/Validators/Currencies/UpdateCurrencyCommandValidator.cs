using FluentValidation;

using Payments.Application.Currencies.Commands.UpdateCurrency;

namespace Payments.Application.Common.Validators.Currencies;

public class UpdateCurrencyCommandValidator : AbstractValidator<UpdateCurrencyCommand>
{
    public UpdateCurrencyCommandValidator() => RuleFor(x => x.Currency).SetValidator(new CurrencyValidator());
}
