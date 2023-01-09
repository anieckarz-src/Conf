using Confab.Modules.Conferences.Application.Dto;
using Confab.Modules.Conferences.Core.Entities;

namespace Confab.Modules.Conferences.Infrastructure.Mappers;

internal static class HostMapper
{
    public static HostDto AsDto(this Host host)
        => new()
        {
            HostId = host.HostId,
            Name = host.Name,
            Description = host.Description,
        };
    
    public static HostDetailsDto AsDetailsDto(this Host host)
        => new()
        {
            HostId = host.HostId,
            Name = host.Name,
            Description = host.Description,
            Conferences = host.Conferences.Select(x => x.AsDto()).ToList(),
        };
}