using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Windows_Application.Models
{
    public class PaymentHistory
    {
        public int PaymentID { get; set; }
        public int Membership_MembershipID { get; set; }
        public DateTime PaymentDate { get; set; }
        public int Amount { get; set; }
        public string PaymentType { get; set; }

    }
}
