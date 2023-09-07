namespace Library_Windows_Application.DTOs
{
    public class OverdueBooksDetailsDTO
    {
        public int bookID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public decimal OverdueFine { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime CurrentDate { get; set; }
        public int DaysLate { get; set; }
    }
}
