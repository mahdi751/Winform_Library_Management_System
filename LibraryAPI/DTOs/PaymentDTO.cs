namespace LibraryAPI.DTOs
{
    public class PaymentDTO
    {
        public int BookID { get; set; }
        public int MembershipID { get; set; }
        public decimal Fine { get; set; }
    }
}
