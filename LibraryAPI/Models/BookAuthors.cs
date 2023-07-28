using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Models
{
    [Table("Bookauthors", Schema = "dbo")]
    public class BookAuthors
    {
        public int Book_BookID { get; set; }
        public int Author_AuthorID { get; set; }
        public string Role { get; set; }
    }
}
