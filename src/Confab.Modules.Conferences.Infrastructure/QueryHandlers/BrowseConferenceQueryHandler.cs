using Confab.Modules.Conferences.Application.Dto;
using Confab.Modules.Conferences.Application.Queries;
using Convey.CQRS.Queries;

namespace Confab.Modules.Conferences.Infrastructure.QueryHandlers;

internal sealed class BrowseConferenceQueryHandler : IQueryHandler<BrowseConferenceQuery, IReadOnlyList<ConferenceDto>>
{
    public Task<IReadOnlyList<ConferenceDto>> HandleAsync(BrowseConferenceQuery query, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}