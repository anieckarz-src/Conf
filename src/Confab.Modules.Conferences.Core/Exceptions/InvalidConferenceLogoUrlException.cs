using Confab.Shared.Abstractions.Exceptions;

namespace Confab.Modules.Conferences.Core.Exceptions;

public class InvalidConferenceLogoUrlException : ConfabException
{
    public InvalidConferenceLogoUrlException() : base("Invalid conference logo url.")
    {
    }
}