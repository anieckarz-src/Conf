using Confab.Modules.Conferences.Application.Dto;
using Confab.Modules.Conferences.Core.Entities;

namespace Confab.Modules.Conferences.Infrastructure.Mappers;

internal static class ConferenceMapper
{
    public static ConferenceDto AsDto(this Conference conference)
        => new()
        {
            ConferenceId = conference.ConferenceId,
            Name = conference.Name,
            Description = conference.Description,
            From = conference.From,
            To = conference.To,
            Location = conference.Location,
            HostId = conference.HostId,
            LogoUrl = conference.LogoUrl,
            ParticipantsLimit = conference.ParticipantsLimit
        };
    
    public static ConferenceDetailsDto AsDetailsDto(this Conference conference)
        => new()
        {
            ConferenceId = conference.ConferenceId,
            Name = conference.Name,
            Description = conference.Description,
            From = conference.From,
            To = conference.To,
            Location = conference.Location,
            HostId = conference.HostId,
            LogoUrl = conference.LogoUrl,
            ParticipantsLimit = conference.ParticipantsLimit,
        };
}