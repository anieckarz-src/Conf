using Confab.Shared.Abstractions.Exceptions;

namespace Confab.Modules.Conferences.Core.Exceptions;

public class InvalidConferenceDescriptionException : ConfabException
{
    public InvalidConferenceDescriptionException() : base("Invalid conference description.")
    {
    }
}