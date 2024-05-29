using FluentValidation;

using Payments.Application.Currencies.Queries.GetCurrency;

namespace Payments.Application.Common.Validators;

public class GetCurrencyGroupQueryValidator : AbstractValidator<GetCurrencyQuery>
{
    public GetCurrencyGroupQueryValidator() => RuleFor(x => x.Id).NotEmpty();
}
