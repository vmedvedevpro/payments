using FluentValidation;

using Payments.Application.Currencies.Commands.DeleteCurrency;

namespace Payments.Application.Common.Validators.Currencies;

public class DeleteCurrencyCommandValidator : AbstractValidator<DeleteCurrencyCommand>
{
    public DeleteCurrencyCommandValidator() => RuleFor(x => x.Id).NotEmpty();
}
