﻿using System.Net;
using Microsoft.AspNetCore.Http;

namespace Confab.Shared.Infrastructure.Exceptions;

internal class ExceptionMiddleware : IMiddleware
{
    private readonly IExceptionCompositionRoot _exceptionCompositionRoot;

    public ExceptionMiddleware(IExceptionCompositionRoot exceptionCompositionRoot)
    {
        _exceptionCompositionRoot = exceptionCompositionRoot;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            await HandleErrorAsync(context, e);
            throw;
        }
    }

    private async Task HandleErrorAsync(HttpContext context, Exception e)
    {
        var errorResponse = _exceptionCompositionRoot.Map(e);

        context.Response.StatusCode = (int)(errorResponse?.StatusCode ?? HttpStatusCode.InternalServerError);
        var response = errorResponse?.Response;

        if (response is null)
        {
            return;
        }

        await context.Response.WriteAsJsonAsync(errorResponse);
    }
}