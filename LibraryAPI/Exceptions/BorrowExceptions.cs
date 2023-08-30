using System;

namespace LibraryAPI.Exceptions
{
    public class BorrowExceptions : Exception
    {
        public class BorrowBookException : Exception
        {
            public BorrowBookException(string message) : base(message) { }
        }

        public class CalculateOverdueFinesException : Exception
        {
            public CalculateOverdueFinesException(string message) : base(message) { }
        }

        public class GetBorrowedBooksException : Exception
        {
            public GetBorrowedBooksException(string message) : base(message) { }
        }

        public class GetUnReturnedBooksException : Exception
        {
            public GetUnReturnedBooksException(string message) : base(message) { }
        }
        public class GetReturnedBooksException : Exception
        {
            public GetReturnedBooksException(string message) : base(message) { }
        }

        public class GetCurrentOverduePaymentsException : Exception
        {
            public GetCurrentOverduePaymentsException(string message) : base(message) { }
        }

        public class GetOverdueBooksException : Exception
        {
            public GetOverdueBooksException(string message) : base(message) { }
        }

        public class ReturnBorrowedBookException : Exception
        {
            public ReturnBorrowedBookException(string message) : base(message) { }
        }
    }
}
