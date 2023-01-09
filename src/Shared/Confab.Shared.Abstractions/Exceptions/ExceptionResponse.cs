using System.Net;

namespace Confab.Shared.Infrastructure.Exceptions;

public record ExceptionResponse(object Response, HttpStatusCode StatusCode);