using FluentValidation;

using Payments.Application.Currencies.Commands.CreateCurrency;

namespace Payments.Application.Common.Validators.Currencies;

public class CreateCurrencyDtoValidator : AbstractValidator<CreateCurrencyDto>
{
    public CreateCurrencyDtoValidator() => RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
}
