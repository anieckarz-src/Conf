using Confab.Modules.Conferences.Application.Dto;

namespace Confab.Modules.Conferences.Api.Requests;

public record UpdateHostDetailsRequest(Guid HostId, string Name, string Description, IEnumerable<ConferenceDto> Conferences);
