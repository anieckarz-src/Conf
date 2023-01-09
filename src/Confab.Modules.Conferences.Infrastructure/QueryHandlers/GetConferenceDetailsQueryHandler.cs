using Confab.Modules.Conferences.Application.Dto;
using Confab.Modules.Conferences.Application.Queries;
using Convey.CQRS.Queries;

namespace Confab.Modules.Conferences.Infrastructure.QueryHandlers;

internal sealed class GetConferenceDetailsQueryHandler : IQueryHandler<GetConferenceDetailsQuery,ConferenceDetailsDto>
{
    public Task<ConferenceDetailsDto> HandleAsync(GetConferenceDetailsQuery query, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}