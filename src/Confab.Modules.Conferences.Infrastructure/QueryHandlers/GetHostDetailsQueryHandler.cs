using Confab.Modules.Conferences.Application.Dto;
using Confab.Modules.Conferences.Application.Queries;
using Convey.CQRS.Queries;

namespace Confab.Modules.Conferences.Infrastructure.QueryHandlers;

internal sealed class GetHostDetailsQueryHandler : IQueryHandler<GetHostDetailsQuery, HostDetailsDto>
{
    public Task<HostDetailsDto> HandleAsync(GetHostDetailsQuery query, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}