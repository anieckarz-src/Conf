using Confab.Modules.Conferences.Core.Exceptions;

namespace Confab.Modules.Conferences.Core.Entities;

public class Conference
{
    public Guid ConferenceId { get; private set; }
    public Guid HostId { get; private set; }
    public Host Host { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string Location { get; private set; }
    public string LogoUrl { get; private set; }
    public int? ParticipantsLimit { get; private set; }
    public DateTime From { get; private set; }
    public DateTime To { get; private set; }

    private Conference(Guid hostId, string name, string description, string location, string logoUrl, int? participantsLimit, DateTime from, DateTime to)
    {
        ConferenceId = Guid.NewGuid();
        HostId = hostId;
        Name = name;
        Description = description;
        Location = location;
        LogoUrl = logoUrl;
        ParticipantsLimit = participantsLimit;
        From = from;
        To = to;
    }
    
    private Conference()
    {
        ConferenceId = Guid.NewGuid();
    }
    
    
    public static Conference Create(Guid hostId, string name, string description, string location, string logoUrl, int? participantsLimit, DateTime from, DateTime to)
    {
        var conference =  new Conference(hostId, name, description, location, logoUrl, participantsLimit, from, to);
        
        conference.ChangeName(name);
        conference.ChangeDescription(description);
        conference.ChangeLocation(location);
        conference.ChangeLogoUrl(logoUrl);
        conference.ChangeParticipantsLimit(participantsLimit);
        conference.ChangeDates(from, to);

        return conference;
    }
    
    public void Update(string name, string description, string location, int? participantsLimit, DateTime from, DateTime to)
    {
        ChangeName(name);
        ChangeDescription(description);
        ChangeLocation(location);
        ChangeParticipantsLimit(participantsLimit);
        ChangeDates(from, to);
    }
    public void ChangeDescription(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new InvalidConferenceDescriptionException();
        }

        Description = description;
    }

    public void ChangeName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new InvalidConferenceNameException();
        }

        Name = name;
    }
    
    public void ChangeLocation(string location)
    {
        if (string.IsNullOrWhiteSpace(location))
        {
            throw new InvalidConferenceLocationException();
        }

        Location = location;
    }
    
    public void ChangeLogoUrl(string logoUrl)
    {
        if (string.IsNullOrWhiteSpace(logoUrl))
        {
            throw new InvalidConferenceLogoUrlException();
        }

        LogoUrl = logoUrl;
    }
    
    public void ChangeParticipantsLimit(int? participantsLimit)
    {
        if (participantsLimit < 0)
        {
            throw new InvalidConferenceParticipantsLimitException();
        }

        ParticipantsLimit = participantsLimit;
    }
    
    public void ChangeDates(DateTime from, DateTime to)
    {
        if (from > to)
        {
            throw new InvalidConferenceDatesException();
        }

        From = from;
        To = to;
    }
}
