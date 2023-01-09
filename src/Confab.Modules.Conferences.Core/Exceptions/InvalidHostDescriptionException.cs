using Confab.Shared.Abstractions.Exceptions;

namespace Confab.Modules.Conferences.Core.Exceptions;

internal class InvalidHostDescriptionException : ConfabException
{
    public InvalidHostDescriptionException() : base("Invalid host description.")
    {
    }
}