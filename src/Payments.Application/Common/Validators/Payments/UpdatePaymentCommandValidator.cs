using FluentValidation;

using Payments.Application.Payments.Commands.UpdatePayment;

namespace Payments.Application.Common.Validators.Payments;

public class UpdatePaymentCommandValidator : AbstractValidator<UpdatePaymentCommand>
{
    public UpdatePaymentCommandValidator()
    {
        RuleFor(x => x.Payment).SetValidator(new PaymentValidator());
    }
}
