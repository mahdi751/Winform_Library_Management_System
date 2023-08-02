using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace LibraryAPI.Exceptions
{
    public class BookExceptionHandeler : IAsyncExceptionFilter
    {
        private readonly ILogger<BookExceptionHandeler> _logger;

        public BookExceptionHandeler(ILogger<BookExceptionHandeler> logger)
        {
            _logger = logger;
        }

        public Task OnExceptionAsync(ExceptionContext context)
        {
            context.HttpContext.Response.ContentType = "application/json";

            string message;
            string errorType;

            if (context.Exception is BookExceptions.NoBooksAvailableException)
            {
                message = context.Exception.Message;
                errorType = "NoBooksAvailable";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (context.Exception is BookExceptions.BooksByTitleNotFoundException)
            {
                message = context.Exception.Message;
                errorType = "BooksByTitleNotFound";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (context.Exception is BookExceptions.BooksByAuthorNameNotFoundException)
            {
                message = context.Exception.Message;
                errorType = "BooksByAuthorNameNotFound";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (context.Exception is BookExceptions.BookByIsbnNotFoundException)
            {
                message = context.Exception.Message;
                errorType = "BookByIsbnNotFound";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else
            {
                message = "An unexpected error occurred";
                errorType = "InternalServerError";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            var errorResponse = new ErrorResponse
            {
                Message = message,
                ErrorType = errorType
            };

            var jsonErrorResponse = JsonSerializer.Serialize(errorResponse);
            context.Result = new ContentResult
            {
                Content = jsonErrorResponse,
                StatusCode = context.HttpContext.Response.StatusCode,
                ContentType = "application/json"
            };

            _logger.LogError(context.Exception, $"An error occurred: {context.Exception.Message}");

            return Task.CompletedTask;
        }
    }
}
