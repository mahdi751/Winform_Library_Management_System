namespace LibraryAPI.Exceptions
{
    public class MembershipExceptions : Exception
    {
        public class MembershipNotFoundException : Exception
        {
            public MembershipNotFoundException(string message) : base(message) { }
        }

        public class MembershipEndDateNotFoundException : Exception
        {
            public MembershipEndDateNotFoundException(string message) : base(message) { }
        }

        public class MembershipCreationException : Exception
        {
            public MembershipCreationException(string message) : base(message) { }
        }

        public class MembershipRenewalException : Exception
        {
            public MembershipRenewalException(string message) : base(message) { }
        }

        public class PaymentHistoryException : Exception
        {
            public PaymentHistoryException(string message) : base(message) { }
        }
    }
}
