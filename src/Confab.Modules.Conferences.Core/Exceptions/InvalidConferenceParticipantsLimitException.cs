using Confab.Shared.Abstractions.Exceptions;

namespace Confab.Modules.Conferences.Core.Exceptions;

public class InvalidConferenceParticipantsLimitException : ConfabException
{
    public InvalidConferenceParticipantsLimitException() : base("Invalid conference participants limit.")
    {
    }
}