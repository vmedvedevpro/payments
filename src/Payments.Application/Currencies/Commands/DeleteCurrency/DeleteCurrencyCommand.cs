using MediatR;

namespace Payments.Application.Currencies.Commands.DeleteCurrency;

public record DeleteCurrencyCommand : IRequest
{
    public Guid Id { get; set; }
}
