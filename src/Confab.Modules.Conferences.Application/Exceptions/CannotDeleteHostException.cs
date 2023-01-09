using Confab.Shared.Abstractions.Exceptions;

namespace Confab.Modules.Conferences.Application.Exceptions;

public class CannotDeleteHostException : ConfabException
{
    public CannotDeleteHostException(Guid id) : base($"Unable to delete host with Id : {id}")
    {
    }
}