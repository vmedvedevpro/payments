using MediatR;

namespace Payments.Application.CurrencyGroups.Commands.CreateCurrencyGroup;

public record CreateCurrencyGroupHandler : IRequestHandler<CreateCurrencyGroupCommand>
{
    public Task Handle(CreateCurrencyGroupCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
