using Confab.Shared.Abstractions.Exceptions;

namespace Confab.Modules.Conferences.Application.Exceptions;

public class ConferenceNotFoundException : ConfabException
{
    public ConferenceNotFoundException(Guid id) : base($"Conference with id:{id} not found.")
    {
    }
    
}