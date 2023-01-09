using Confab.Shared.Abstractions.Exceptions;

namespace Confab.Modules.Conferences.Core.Exceptions;

public class InvalidConferenceDatesException : ConfabException
{
    public InvalidConferenceDatesException() : base("Conference dates are invalid.")
    {
    }
}