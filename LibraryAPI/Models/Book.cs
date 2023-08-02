using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Models
{
    [Table("Book", Schema = "dbo")]
    public class Book
    {
        public int Bookid { get; set; }
        public string Booktitle { get; set; }
        public string Isbn { get; set; }
        public int Totalquantity { get; set; }
        public int AvailableQuantity { get; set; }
        public string Genre { get; set; }
        public string Publishername { get; set; }
        public DateTime Publicationdate { get; set; }

    }
}
