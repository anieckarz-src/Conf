using Confab.Shared.Abstractions.Exceptions;

namespace Confab.Modules.Conferences.Core.Exceptions;

public class InvalidConferenceNameException : ConfabException
{
    public InvalidConferenceNameException() : base("Invalid conference name.")
    {
    }
}