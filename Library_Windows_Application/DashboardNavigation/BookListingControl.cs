using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Windows_Application.Dashboard_Controls
{
    public partial class BookListingControl : UserControl
    {
        private string _title;
        private string _genre;
        private int _quantity;
        private string _publishDate;
        private string _publisherName;
        private string _authorName;
        private Image _image;
        public BookListingControl()
        {
            InitializeComponent();
        }
        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; TitleLabel.Text = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; GenreLabel.Text = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; AvailableLabel.Text = value.ToString(); }
        }

        public string Publisher
        {
            get { return _publisherName; }
            set { _publisherName = value; PublisherLabel.Text = value; }
        }


        public string PublishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; PublishDateLabel.Text = value.ToString(); }
        }
        public string Authorname
        {
            get { return _authorName; }
            set { _authorName = value; AuthorName.Text = value; }
        }

        public Label Availablelabel => AvailableLabel;

        public Button BorrowButton => BorrowBtn;

        public Button ReviewButton => ReviewBtn;
    }
}
