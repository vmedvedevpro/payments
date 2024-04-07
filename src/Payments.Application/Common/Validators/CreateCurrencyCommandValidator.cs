using FluentValidation;

using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;
using Payments.Application.Currencies.Commands.CreateCurrency;

namespace Payments.Application.Common.Validators;

public class CreateCurrencyCommandValidator : AbstractValidator<CreateCurrencyCommand>
{
    public CreateCurrencyCommandValidator(IRepository repository)
    {
        RuleFor(x => x.Currency.Name).NotEmpty().WithMessage("Currency name is required");
        RuleFor(x => x.Currency.Name).MustAsync((s, token) => CheckUniqueAsync(s, repository, token))
                                     .WithMessage("Currency name must be unique");
    }

    private static async Task<bool> CheckUniqueAsync(string name, IRepository repository, CancellationToken cancellationToken)
    {
        await using var transaction = await repository.BeginTransactionAsync<Currency>(cancellationToken);
        return !await transaction.Set.AnyAsync(x => x.Name == name, cancellationToken);
    }
}
