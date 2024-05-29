using FluentValidation;

using Payments.Application.PaymentSystems.Commands.DeletePaymentSystem;

namespace Payments.Application.Common.Validators.PaymentSystems;

public class DeletePaymentSystemCommandValidator : AbstractValidator<DeletePaymentSystemCommand>
{
    public DeletePaymentSystemCommandValidator() => RuleFor(x => x.Id).NotEmpty();
}
