using Convey.CQRS.Commands;

namespace Confab.Modules.Conferences.Application.Commands;

public record DeleteHostCommand(Guid HostId) : ICommand;
