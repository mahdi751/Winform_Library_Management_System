namespace LibraryAPI.DTOs
{
    public class ReviewDTO
    {
        public int BookID { get; set; }
        public int MembershipID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
