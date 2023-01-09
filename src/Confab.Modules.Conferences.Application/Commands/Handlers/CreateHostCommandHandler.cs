using Confab.Modules.Conferences.Core.Entities;
using Confab.Modules.Conferences.Core.Repositories;
using Convey.CQRS.Commands;

namespace Confab.Modules.Conferences.Application.Commands.Handlers;

internal sealed class CreateHostCommandHandler : ICommandHandler<CreateHostCommand>
{
    private readonly IHostRepository _hostRepository;

    public CreateHostCommandHandler(IHostRepository hostRepository)
    {
        _hostRepository = hostRepository;
    }

    public async Task HandleAsync(CreateHostCommand command, CancellationToken cancellationToken = new CancellationToken())
    {
        var host = Host.Create(command.Name, command.Description);
        
        await _hostRepository.AddAsync(host);
    }
}