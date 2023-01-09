namespace Confab.Modules.Conferences.Api.Requests;

public record CreateConferenceRequest(Guid HostId, string Name, string Description, string Location, string LogoUrl,
    int? ParticipantsLimit, DateTime From, DateTime To);