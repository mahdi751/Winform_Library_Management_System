using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace LibraryAPI.Exceptions
{
    public class PaymentExceptionHandler : IAsyncExceptionFilter
    {
        private readonly ILogger<PaymentExceptionHandler> _logger;

        public PaymentExceptionHandler(ILogger<PaymentExceptionHandler> logger)
        {
            _logger = logger;
        }

        public Task OnExceptionAsync(ExceptionContext context)
        {
            context.HttpContext.Response.ContentType = "application/json";

            string message;
            string errorType;

            if (context.Exception is PaymentExceptions.InvalidPaymentDataException)
            {
                message = context.Exception.Message;
                errorType = "InvalidPaymentData";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if(context.Exception is PaymentExceptions.PaymentException)
            {
                message = context.Exception.Message;
                errorType = "DataModificationError!";
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
