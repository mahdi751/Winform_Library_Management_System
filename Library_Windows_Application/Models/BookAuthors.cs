using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Windows_Application.Models
{
    public class BookAuthors
    {
        public int Book_BookID { get; set; }
        public int Author_AuthorID { get; set; }
        public string Role { get; set; }
    }
}
