using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models
{
    [Table("PaymentHistory", Schema = "dbo")]
    public class PaymentHistory
    {
        public int PaymentID { get; set; }
        public int User_UserID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }

    }
}
