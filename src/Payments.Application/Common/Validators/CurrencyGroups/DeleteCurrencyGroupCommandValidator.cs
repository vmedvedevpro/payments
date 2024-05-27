using FluentValidation;

using Payments.Application.CurrencyGroups.Commands.DeleteCurrencyGroup;

namespace Payments.Application.Common.Validators.CurrencyGroups;

public class DeleteCurrencyGroupCommandValidator : AbstractValidator<DeleteCurrencyGroupCommand>
{
    public DeleteCurrencyGroupCommandValidator() => RuleFor(x => x.Id).NotEmpty();
}
