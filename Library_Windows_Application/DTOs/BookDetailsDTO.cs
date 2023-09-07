using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Windows_Application.DTOs
{
    public class BookDetailsDTO
    {
        public int Bookid { get; set; }
        public string Booktitle { get; set; }
        public string AuthorName { get; set; }
        public int AvailableQuantity { get; set; }
        public string Genre { get; set; }
        public string Publishername { get; set; }
        public DateTime Publicationdate { get; set; }
    }
}
