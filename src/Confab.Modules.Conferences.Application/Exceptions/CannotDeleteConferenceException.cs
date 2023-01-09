using Confab.Shared.Abstractions.Exceptions;

namespace Confab.Modules.Conferences.Application.Exceptions;

public class CannotDeleteConferenceException : ConfabException
{
    public CannotDeleteConferenceException(Guid id) : base($"unable to delete conference with id: {id}")
    {
    }
}