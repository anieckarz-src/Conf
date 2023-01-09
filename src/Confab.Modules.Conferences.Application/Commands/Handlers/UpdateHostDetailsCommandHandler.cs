using Confab.Modules.Conferences.Application.Exceptions;
using Confab.Modules.Conferences.Core.Exceptions;
using Confab.Modules.Conferences.Core.Repositories;
using Convey.CQRS.Commands;

namespace Confab.Modules.Conferences.Application.Commands.Handlers;

internal sealed class UpdateHostDetailsCommandHandler : ICommandHandler<UpdateHostDetailsCommand>
{
    private readonly IHostRepository _hostRepository;
    
    public UpdateHostDetailsCommandHandler(IHostRepository hostRepository)
    {
        _hostRepository = hostRepository;
    }
    
    public async Task HandleAsync(UpdateHostDetailsCommand command, CancellationToken cancellationToken = new CancellationToken())
    {
        var host = await _hostRepository.GetAsync(command.HostId);

        if (host is null)
        {
            throw new HostNotFoundException(command.HostId);
        }
        
        host.Update(command.Name,command.Description);
        
        
        await _hostRepository.UpdateAsync(host);
    }
}