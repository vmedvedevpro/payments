using FluentValidation;

using Payments.Application.PaymentSystems.Commands.UpdatePaymentSystem;

namespace Payments.Application.Common.Validators.PaymentSystems;

public class UpdatePaymentSystemCommandValidator : AbstractValidator<UpdatePaymentSystemCommand>

{
    public UpdatePaymentSystemCommandValidator() => RuleFor(x => x.PaymentSystem).SetValidator(new PaymentSystemValidator());
}
