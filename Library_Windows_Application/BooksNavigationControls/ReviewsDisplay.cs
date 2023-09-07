using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Windows_Application.BooksNavigation
{
    public partial class ReviewsDisplay : UserControl
    {
        private string username;
        private string _reviewDate;
        private Image _image;
        private string comment;
        private int rating;

        public ReviewsDisplay()
        {
            InitializeComponent();
        }
        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }
        public string UserName
        {
            get { return username; }
            set { username = value; Username.Text = value; }
        }
        public string Comment
        {
            get { return comment; }
            set { comment = value; CommentText.Text = value; }
        }
        public string ReviewDate
        {
            get { return _reviewDate; }
            set { _reviewDate = value; reviewDate.Text = value; }
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public FlowLayoutPanel StarsPanel
        {
            get { return RatingPanel; }
        }
    }
}
