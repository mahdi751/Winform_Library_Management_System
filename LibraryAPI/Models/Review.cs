using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Models
{
    [Table("Review", Schema = "dbo")]
    public class Review
    {
        public int Membership_MembershipID { get; set; }
        public int Book_BookID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }


    }
}
