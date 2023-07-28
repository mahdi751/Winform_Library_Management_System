using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Models
{
    [Table("Borrow", Schema = "dbo")]
    public class Borrow
    {
        public int Membership_MembershipID { get; set; }
        public int Book_BookID { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal Overduefine { get; set; }

    }
}
