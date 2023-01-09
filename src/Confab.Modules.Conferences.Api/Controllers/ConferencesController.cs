using Confab.Modules.Conferences.Api.Requests;
using Confab.Modules.Conferences.Application.Commands;
using Confab.Modules.Conferences.Application.Dto;
using Confab.Modules.Conferences.Application.Queries;
using Convey.CQRS.Commands;
using Convey.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Confab.Modules.Conferences.Api.Controllers;

internal class ConferencesController : ControllerBase
{
    private readonly ICommandDispatcher _commandDispatcher;
    private readonly IQueryDispatcher _queryDispatcher;

    public ConferencesController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
    {
        _commandDispatcher = commandDispatcher;
        _queryDispatcher = queryDispatcher;
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<ConferenceDetailsDto>> GetAsync(Guid id)
        => await _queryDispatcher.QueryAsync(new GetConferenceDetailsQuery(id));

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<ConferenceDto>>> BrowseAsync()
        => Ok(await _queryDispatcher.QueryAsync(new BrowseConferenceQuery()));

    [HttpPost]
    public async Task<ActionResult> PostAsync([FromBody] CreateConferenceRequest request)
    {
        await _commandDispatcher.SendAsync(new CreateConferenceCommand(request.HostId, request.Name,
            request.Description, request.Location, request.LogoUrl, request.ParticipantsLimit, request.From,
            request.To));

        return Ok();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        await _commandDispatcher.SendAsync(new DeleteConferenceCommand(id));

        return Ok();
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> PutAsync([FromBody] UpdateConferenceRequest request, Guid id)
    {
        await _commandDispatcher.SendAsync(new UpdateConferenceCommand(id, request.HostId, request.Name,
            request.Description,
            request.Location, request.LogoUrl, request.ParticipantsLimit, request.From,
            request.To));

        return Ok();
    }
}