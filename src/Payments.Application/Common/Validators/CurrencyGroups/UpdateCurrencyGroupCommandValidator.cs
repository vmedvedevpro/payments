using FluentValidation;

using Payments.Application.CurrencyGroups.Commands.UpdateCurrencyGroup;

namespace Payments.Application.Common.Validators.CurrencyGroups;

public class UpdateCurrencyGroupCommandValidator : AbstractValidator<UpdateCurrencyGroupCommand>
{
    public UpdateCurrencyGroupCommandValidator() => RuleFor(x => x.CurrencyGroup).SetValidator(new CurrencyGroupValidator());
}
