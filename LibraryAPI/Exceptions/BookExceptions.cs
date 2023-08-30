using System;

namespace LibraryAPI.Exceptions
{
    public class BookExceptions : Exception
    {
        public class NoBooksAvailableException : Exception
        {
            public NoBooksAvailableException(string message) : base(message) { }
        }

        public class BooksByTitleNotFoundException : Exception
        {
            public BooksByTitleNotFoundException(string message) : base(message) { }
        }

        public class BooksByGenreNotFoundException : Exception
        {
            public BooksByGenreNotFoundException(string message) : base(message) { }
        }

        public class BooksByAuthorNameNotFoundException : Exception
        {
            public BooksByAuthorNameNotFoundException(string message) : base(message) { }
        }

        public class BookByIsbnNotFoundException : Exception
        {
            public BookByIsbnNotFoundException(string message) : base(message) { }
        }

    }
}
