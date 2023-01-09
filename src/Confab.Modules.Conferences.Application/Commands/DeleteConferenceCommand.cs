using Convey.CQRS.Commands;

namespace Confab.Modules.Conferences.Application.Commands;

public record DeleteConferenceCommand(Guid ConferenceId) : ICommand;