using Confab.Modules.Conferences.Application.Exceptions;
using Confab.Modules.Conferences.Core.Entities;
using Confab.Modules.Conferences.Core.Repositories;
using Convey.CQRS.Commands;

namespace Confab.Modules.Conferences.Application.Commands.Handlers;

internal sealed class CreateConferenceCommandHandler : ICommandHandler<CreateConferenceCommand>
{
    private readonly IConferenceRepository _conferenceRepository;
    private readonly IHostRepository _hostRepository;

    public CreateConferenceCommandHandler(IConferenceRepository conferenceRepository, IHostRepository hostRepository)
    {
        _conferenceRepository = conferenceRepository;
        _hostRepository = hostRepository;
    }

    public async Task HandleAsync(CreateConferenceCommand command,
        CancellationToken cancellationToken = new CancellationToken())
    {
        if (await _hostRepository.GetAsync(command.HostId) is null)
        {
            throw new HostNotFoundException(command.HostId);
        }

        var conference = Conference.Create(command.HostId, command.Name, command.Description, command.Location,
            command.LogoUrl, command.ParticipantsLimit, command.From, command.To);
        
        await _conferenceRepository.AddAsync(conference);
    }
}