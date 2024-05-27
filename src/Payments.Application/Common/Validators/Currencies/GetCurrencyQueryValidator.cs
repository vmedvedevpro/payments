using FluentValidation;

using Payments.Application.Currencies.Queries.GetCurrency;

namespace Payments.Application.Common.Validators.Currencies;

public class GetCurrencyQueryValidator : AbstractValidator<GetCurrencyQuery>
{
    public GetCurrencyQueryValidator() => RuleFor(x => x.Id).NotEmpty();
}
