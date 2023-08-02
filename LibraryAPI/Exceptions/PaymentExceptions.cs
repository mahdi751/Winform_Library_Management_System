using System;

namespace LibraryAPI.Exceptions
{
    public class PaymentExceptions : Exception
    {

        public class InvalidPaymentDataException : Exception
        {
            public InvalidPaymentDataException(string message) : base(message) { }
        }

        public class PaymentException : Exception 
        {
            public PaymentException(string message) : base(message) { }
        }

    }
}
