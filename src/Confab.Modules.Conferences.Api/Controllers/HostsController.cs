using Confab.Modules.Conferences.Api.Requests;
using Confab.Modules.Conferences.Application.Commands;
using Confab.Modules.Conferences.Application.Dto;
using Confab.Modules.Conferences.Application.Queries;
using Confab.Modules.Conferences.Infrastructure.EF.Repositories;
using Convey.CQRS.Commands;
using Convey.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Confab.Modules.Conferences.Api.Controllers;

internal class HostsController : BaseController
{
    private readonly IQueryDispatcher _queryDispatcher;
    private readonly ICommandDispatcher _commandDispatcher;

    public HostsController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
    {
        _queryDispatcher = queryDispatcher;
        _commandDispatcher = commandDispatcher;
    }


    [HttpGet("details/{hostId:guid}")]
    public async Task<ActionResult<HostDetailsDto>> GetDetailsAsync(Guid hostId)
        => OkOrNotFound(await _queryDispatcher.QueryAsync(new GetHostDetailsQuery(hostId)));

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<HostDto>>> BrowseAsync()
        => Ok(await _queryDispatcher.QueryAsync(new BrowseHostQuery()));

    [HttpPost]
    public async Task<ActionResult> AddAsync(CreateHostRequest request)
    {
        await _commandDispatcher.SendAsync(new CreateHostCommand(request.Name, request.Description));
       
        return Ok();
    }

    [HttpPut]
    public async Task<ActionResult> UpdateAsync(UpdateHostDetailsRequest request)
    {
        await _commandDispatcher.SendAsync(new UpdateHostDetailsCommand(request.HostId, request.Name,
            request.Description, request.Conferences));
        
        return Ok();
    }
    
    [HttpDelete("{hostId:guid}")]
    public async Task<ActionResult> DeleteAsync(Guid hostId)
    {
        await _commandDispatcher.SendAsync(new DeleteHostCommand(hostId));
        
        return Ok();
    }
}