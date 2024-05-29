using FluentValidation;

using Payments.Application.CurrencyGroups.Commands.CreateCurrencyGroup;

namespace Payments.Application.Common.Validators.Currencies;

public class CreateCurrencyGroupDtoValidator : AbstractValidator<CreateCurrencyGroupDto>
{
    public CreateCurrencyGroupDtoValidator() => RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
}
