using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Models
{
    [Table("Membership", Schema = "dbo")]
    public class Membership
    {
        public int MembershipID { get; set; }
        public string MembershipName { get; set; }
        public int MaxBorrowLimit { get; set; }
        public int RemainingBorrowAbility { get; set; }
        public double MembershipPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int User_UserID { get; set; }
    }
}
