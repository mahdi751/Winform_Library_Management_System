using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Windows_Application.PaymentControls
{
    public partial class FinesDisplayControl : UserControl
    {
        public FinesDisplayControl()
        {
            InitializeComponent();
        }

        private string _title;
        private string _genre;
        private string _authorName;
        private Image _image;
        private decimal fine;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        public string Authorname
        {
            get { return _authorName; }
            set { _authorName = value; AuthorName.Text = value; }
        }

        public decimal Fine
        {
            get { return fine; }
            set { fine = value; FineLabel.Text = "Fine to pay : " + fine + " $"; }
        }

        public Button PayFineButton => PayFineBtn;

        public Button DetailsButton => DetailsBtn;

        public FlowLayoutPanel DisplayDetailsPanel => DetailsPanel;

    }
}
