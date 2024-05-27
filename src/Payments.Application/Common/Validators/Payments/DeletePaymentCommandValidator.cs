using FluentValidation;

using Payments.Application.Payments.Commands.DeletePayment;

namespace Payments.Application.Common.Validators.Payments;

public class DeletePaymentCommandValidator : AbstractValidator<DeletePaymentCommand>
{
    public DeletePaymentCommandValidator() => RuleFor(x => x.Id).NotEmpty().WithMessage("Payment id is required");
}
