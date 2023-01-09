using Convey.CQRS.Commands;

namespace Confab.Modules.Conferences.Application.Commands;

public record CreateHostCommand(string Name, string Description) : ICommand;