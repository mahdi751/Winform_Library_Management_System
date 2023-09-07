using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Windows_Application.DTOs
{
    public class BorrowDetailsDTO
    {
        public int Bookid { get; set; }
        public string Booktitle { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public bool IsReturned { get; set; }
        public decimal Fine { get; set; }
    }
}
