using Confab.Shared.Abstractions.Exceptions;

namespace Confab.Modules.Conferences.Core.Exceptions;

public class InvalidConferenceLocationException : ConfabException
{
    public InvalidConferenceLocationException() : base("Invalid conference location.")
    {
    }
    
}