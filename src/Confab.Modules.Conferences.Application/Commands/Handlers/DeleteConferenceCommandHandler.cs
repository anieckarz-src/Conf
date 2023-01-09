using Confab.Modules.Conferences.Application.Exceptions;
using Confab.Modules.Conferences.Core.Policies;
using Confab.Modules.Conferences.Core.Repositories;
using Convey.CQRS.Commands;

namespace Confab.Modules.Conferences.Application.Commands.Handlers;

internal sealed class DeleteConferenceCommandHandler : ICommandHandler<DeleteConferenceCommand>
{
    private readonly IConferenceRepository _conferenceRepository;
    private readonly IConferenceDeletionPolicy _conferenceDeletionPolicy;

    public DeleteConferenceCommandHandler(IConferenceRepository conferenceRepository,
        IConferenceDeletionPolicy conferenceDeletionPolicy)
    {
        _conferenceRepository = conferenceRepository;
        _conferenceDeletionPolicy = conferenceDeletionPolicy;
    }

    public async Task HandleAsync(DeleteConferenceCommand command,
        CancellationToken cancellationToken = new CancellationToken())
    {
        var conference = await _conferenceRepository.GetAsync(command.ConferenceId);

        if(conference is null)
        {
            throw new ConferenceNotFoundException(command.ConferenceId);
        }

        if(await _conferenceDeletionPolicy.CanDeleteAsync(conference) is false)
        {
            throw new CannotDeleteConferenceException(command.ConferenceId);
        }

        await _conferenceRepository.DeleteAsync(conference);
    }
}