using FluentValidation;

using Payments.Application.Currencies.Commands.CreateCurrency;

namespace Payments.Application.Common.Validators.Currencies;

public class CreateCurrencyCommandValidator : AbstractValidator<CreateCurrencyCommand>
{
    public CreateCurrencyCommandValidator() =>
        RuleFor(x => x.Currency).SetValidator(new CreateCurrencyDtoValidator());
}
