using Confab.Modules.Conferences.Application.Exceptions;
using Confab.Modules.Conferences.Core.Exceptions;
using Confab.Modules.Conferences.Core.Policies;
using Confab.Modules.Conferences.Core.Repositories;
using Convey.CQRS.Commands;

namespace Confab.Modules.Conferences.Application.Commands.Handlers;

internal sealed class DeleteHostCommandHandler : ICommandHandler<DeleteHostCommand>
{
    private readonly IHostRepository _hostRepository;
    private readonly IHostDeletionPolicy _deletionPolicy;
    
    public DeleteHostCommandHandler(IHostRepository hostRepository, IHostDeletionPolicy deletionPolicy)
    {
        _hostRepository = hostRepository;
        _deletionPolicy = deletionPolicy;
    }
    
    
    public async Task HandleAsync(DeleteHostCommand command, CancellationToken cancellationToken = new CancellationToken())
    {
        var host = await _hostRepository.GetAsync(command.HostId);

        if (host is null)
        {
            throw new HostNotFoundException(command.HostId);
        }

        if (await _deletionPolicy.CanDeleteAsync(host) is false)
        {
            throw new CannotDeleteHostException(host.HostId);
        }
        
        await _hostRepository.DeleteAsync(host);
    }
}