using MediatR;

namespace Payments.Application.CurrencyGroups.Commands.UpdateCurrencyGroup;

public record UpdateCurrencyGroupHandler : IRequestHandler<UpdateCurrencyGroupCommand>
{
    public Task Handle(UpdateCurrencyGroupCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
