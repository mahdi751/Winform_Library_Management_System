using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Models
{
    [Table("Author", Schema = "dbo")]
    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string Biography { get; set; }

    }
}
