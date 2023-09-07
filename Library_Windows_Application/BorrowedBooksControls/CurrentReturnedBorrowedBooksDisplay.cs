using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Windows_Application.BorrowedBooksControl_Components
{
    public partial class CurrentReturnedBorrowedBooksDisplay : UserControl
    {
        public CurrentReturnedBorrowedBooksDisplay()
        {
            InitializeComponent();
        }

        private string authorname;
        private string genre;
        private Image _image;
        private string bookTitle;

        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }
        public string Author
        {
            get { return authorname; }
            set { authorname = value; AuthorName.Text = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; GenreType.Text = value; }
        }
        public string BookTitle
        {
            get { return bookTitle; }
            set { bookTitle = value; Title.Text = value; }
        }
        public string ReturnLabel
        {
            get { return ReturnDetails.Text; }
            set { ReturnDetails.Text = value; }
        }
        public string BorrowDateLabel
        {
            get { return BorrowLabel.Text; }
            set { BorrowLabel.Text = value; }
        }
    }
}
