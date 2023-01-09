namespace Confab.Modules.Conferences.Application.Dto;


public class HostDto
{
    public Guid HostId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}


public class HostDetailsDto : HostDto
{
    public IEnumerable<ConferenceDto> Conferences { get; set; }
}