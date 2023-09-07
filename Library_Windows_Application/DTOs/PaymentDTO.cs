using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Windows_Application.DTOs
{
    public class PaymentDTO
    {
        public int BookID { get; set; }
        public int MembershipID { get; set; }
        public decimal Fine { get; set; }
    }
}
