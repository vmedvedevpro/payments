using MediatR;

namespace Payments.Application.CurrencyGroups.Commands.DeleteCurrencyGroup;

public record DeleteCurrencyGroupHandler : IRequestHandler<DeleteCurrencyGroupCommand>
{
    public Task Handle(DeleteCurrencyGroupCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
