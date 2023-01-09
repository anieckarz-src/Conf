using Confab.Shared.Abstractions.Exceptions;

namespace Confab.Modules.Conferences.Core.Exceptions;

internal class InvalidHostNameException : ConfabException
{
    public InvalidHostNameException() : base("Invalid host name.")
    {
    }
}