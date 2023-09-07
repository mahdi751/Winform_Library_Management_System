namespace LibraryAPI.DTOs
{
    public class ReviewDetailsDTO
    {
        public int BookID { get; set; }
        public int MembershipID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public string Username { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
