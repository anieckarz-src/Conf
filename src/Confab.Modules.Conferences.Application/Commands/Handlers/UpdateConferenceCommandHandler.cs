using Confab.Modules.Conferences.Application.Exceptions;
using Confab.Modules.Conferences.Core.Repositories;
using Convey.CQRS.Commands;

namespace Confab.Modules.Conferences.Application.Commands.Handlers;

internal sealed class UpdateConferenceCommandHandler : ICommandHandler<UpdateConferenceCommand>
{
    private readonly IConferenceRepository _conferenceRepository;
    
    public UpdateConferenceCommandHandler(IConferenceRepository conferenceRepository)
    {
        _conferenceRepository = conferenceRepository;
    }
    
    
    public async Task HandleAsync(UpdateConferenceCommand command, CancellationToken cancellationToken = new CancellationToken())
    {
        var conference = await _conferenceRepository.GetAsync(command.ConferenceId);

        if (conference is null)
        {
            throw new ConferenceNotFoundException(command.ConferenceId);
        }
        
        conference.Update(command.Name,command.Description,command.Location,command.ParticipantsLimit,command.From,command.To);
        
        await _conferenceRepository.UpdateAsync(conference);
        
    }
}