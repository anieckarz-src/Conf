using Confab.Modules.Conferences.Core.Exceptions;

namespace Confab.Modules.Conferences.Core.Entities;

public class Host
{
    public Guid HostId { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public IEnumerable<Conference> Conferences { get; private set; }

    private Host()
    {
        HostId = Guid.NewGuid();
    }

    public static Host Create(string name, string description)
    {
        var host = new Host();
        
        host.ChangeDescription(description);
        host.ChangeName(name);

        return host;
    }

    private Host(string name, string description)
    {
        HostId = Guid.NewGuid();
        Name = name;
        Description = description;
    }
    
    private Host(string name, string description, IEnumerable<Conference> conferences)
    {
        HostId = Guid.NewGuid();
        Name = name;
        Description = description;
        Conferences = conferences;
    }

    public void Update(string name, string description)
    {
        ChangeName(name);
        ChangeDescription(description);
    }

    public void ChangeDescription(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new InvalidHostDescriptionException();
        }

        Description = description;
    }

    public void ChangeName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new InvalidHostNameException();
        }

        Name = name;
    }
}