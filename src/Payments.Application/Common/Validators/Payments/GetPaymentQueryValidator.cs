using FluentValidation;

using Payments.Application.Payments.Queries.GetPayment;

namespace Payments.Application.Common.Validators.Payments;

public class GetPaymentQueryValidator : AbstractValidator<GetPaymentQuery>
{
    public GetPaymentQueryValidator() => RuleFor(x => x.Id).NotEmpty().WithMessage("Payment id is required");
}
