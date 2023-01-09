using Convey.CQRS.Commands;

namespace Confab.Modules.Conferences.Application.Commands;

public record CreateConferenceCommand(Guid HostId, string Name, string Description, string Location, string LogoUrl,
    int? ParticipantsLimit, DateTime From, DateTime To) : ICommand;