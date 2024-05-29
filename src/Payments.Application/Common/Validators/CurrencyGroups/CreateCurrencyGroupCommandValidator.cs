using FluentValidation;

using Payments.Application.Common.Validators.Currencies;
using Payments.Application.CurrencyGroups.Commands.CreateCurrencyGroup;

namespace Payments.Application.Common.Validators.CurrencyGroups;

public class CreateCurrencyGroupCommandValidator : AbstractValidator<CreateCurrencyGroupCommand>
{
    public CreateCurrencyGroupCommandValidator() =>
        RuleFor(x => x.CurrencyGroup).SetValidator(new CreateCurrencyGroupDtoValidator());
}
