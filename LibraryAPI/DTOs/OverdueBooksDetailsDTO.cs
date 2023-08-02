namespace LibraryAPI.DTOs
{
    public class OverdueBooksDetailsDTO
    {
        public string Title { get; set; }
        public string Isbn { get; set; }
        public decimal OverdueFine { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime CurrentDate { get; set; }
        public int DaysLate { get; set; }
    }
}
