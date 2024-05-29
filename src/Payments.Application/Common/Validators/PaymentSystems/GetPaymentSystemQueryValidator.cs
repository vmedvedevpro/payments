using FluentValidation;

using Payments.Application.PaymentSystems.Queries.GetPaymentSystem;

namespace Payments.Application.Common.Validators.PaymentSystems;

public class GetPaymentSystemQueryValidator : AbstractValidator<GetPaymentSystemQuery>
{
    public GetPaymentSystemQueryValidator() => RuleFor(x => x.Id).NotEmpty();
}
