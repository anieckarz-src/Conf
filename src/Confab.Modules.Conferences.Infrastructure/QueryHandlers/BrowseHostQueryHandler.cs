using Confab.Modules.Conferences.Application.Dto;
using Confab.Modules.Conferences.Application.Queries;
using Convey.CQRS.Queries;

namespace Confab.Modules.Conferences.Infrastructure.QueryHandlers;

internal sealed class BrowseHostQueryHandler : IQueryHandler<BrowseHostQuery, IReadOnlyList<HostDto>>
{
    public Task<IReadOnlyList<HostDto>> HandleAsync(BrowseHostQuery query, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}