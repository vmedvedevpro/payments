using MediatR;

namespace Payments.Application.CurrencyGroups.Commands.DeleteCurrencyGroup;

public record DeleteCurrencyGroupCommand : IRequest
{
    public Guid Id { get; set; }
}
