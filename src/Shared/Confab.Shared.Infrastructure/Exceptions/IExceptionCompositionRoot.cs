﻿namespace Confab.Shared.Infrastructure.Exceptions;

internal interface IExceptionCompositionRoot
{
    ExceptionResponse Map(Exception exception);
}