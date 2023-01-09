using Confab.Modules.Conferences.Application.Dto;
using Convey.CQRS.Queries;

namespace Confab.Modules.Conferences.Application.Queries;

public record GetConferenceDetailsQuery(Guid ConferenceId) : IQuery<ConferenceDetailsDto>;
