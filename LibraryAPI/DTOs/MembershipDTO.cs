namespace LibraryAPI.DTOs
{
    public class MembershipDTO
    {
        public string MembershipName { get; set; }
        public int MaxBorrowLimit { get; set; }
        public double MembershipPrice { get; set; }
        public int User_UserID { get; set; }
    }
}
