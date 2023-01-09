using Confab.Modules.Conferences.Application.Dto;
using Convey.CQRS.Commands;

namespace Confab.Modules.Conferences.Application.Commands;

public record UpdateHostDetailsCommand(Guid HostId, string Name, string Description, IEnumerable<ConferenceDto> Conferences) : ICommand;