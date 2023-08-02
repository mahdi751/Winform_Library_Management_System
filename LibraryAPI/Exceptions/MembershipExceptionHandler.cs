using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace LibraryAPI.Exceptions
{
    public class MembershipExceptionHandler : IAsyncExceptionFilter
    {
        private readonly ILogger<MembershipExceptionHandler> _logger;

        public MembershipExceptionHandler(ILogger<MembershipExceptionHandler> logger)
        {
            _logger = logger;
        }

        public Task OnExceptionAsync(ExceptionContext context)
        {
            context.HttpContext.Response.ContentType = "application/json";

            string message;
            string errorType;

            if (context.Exception is MembershipExceptions.MembershipNotFoundException)
            {
                message = context.Exception.Message;
                errorType = "MembershipNotFound";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            else if (context.Exception is MembershipExceptions.MembershipEndDateNotFoundException)
            {
                message = context.Exception.Message;
                errorType = "MembershipEndDateNotFound";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            else if (context.Exception is MembershipExceptions.MembershipCreationException)
            {
                message = context.Exception.Message;
                errorType = "MembershipCreationError";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (context.Exception is MembershipExceptions.MembershipRenewalException)
            {
                message = context.Exception.Message;
                errorType = "MembershipRenewalError";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if(context.Exception is MembershipExceptions.PaymentHistoryException)
            {
                message = context.Exception.Message;
                errorType = "PaymentHistoryInsertionError";
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
