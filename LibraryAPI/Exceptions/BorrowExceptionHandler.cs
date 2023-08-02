using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace LibraryAPI.Exceptions
{
    public class BorrowExceptionHandler : IAsyncExceptionFilter
    {
        private readonly ILogger<BorrowExceptionHandler> _logger;

        public BorrowExceptionHandler(ILogger<BorrowExceptionHandler> logger)
        {
            _logger = logger;
        }

        public Task OnExceptionAsync(ExceptionContext context)
        {
            context.HttpContext.Response.ContentType = "application/json";

            string message;
            string errorType;

            if (context.Exception is BorrowExceptions.BorrowBookException)
            {
                message = context.Exception.Message;
                errorType = "BorrowBook";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (context.Exception is BorrowExceptions.CalculateOverdueFinesException)
            {
                message = context.Exception.Message;
                errorType = "CalculateOverdueFines";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (context.Exception is BorrowExceptions.GetBorrowedBooksException)
            {
                message = context.Exception.Message;
                errorType = "GetBorrowedBooks";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (context.Exception is BorrowExceptions.GetUnReturnedBooksException)
            {
                message = context.Exception.Message;
                errorType = "GetUnReturnedBooks";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (context.Exception is BorrowExceptions.GetCurrentOverduePaymentsException)
            {
                message = context.Exception.Message;
                errorType = "GetCurrentOverduePayments";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (context.Exception is BorrowExceptions.GetOverdueBooksException)
            {
                message = context.Exception.Message;
                errorType = "GetOverdueBooks";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (context.Exception is BorrowExceptions.ReturnBorrowedBookException)
            {
                message = context.Exception.Message;
                errorType = "ReturnBorrowedBook";
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
