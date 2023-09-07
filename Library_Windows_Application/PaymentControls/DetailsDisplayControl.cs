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
    public partial class DetailsDisplayControl : UserControl
    {
        public DetailsDisplayControl()
        {
            InitializeComponent();
        }

        public string PickupDate
        {
            get { return PickUpDate.Text; }
            set { PickUpDate.Text = value; }
        }

        public string Returndate
        {
            get { return ReturnDate.Text; }
            set { ReturnDate.Text = value; }
        }

        public string Currentdate
        {
            get { return CurrentDate.Text; }
            set { CurrentDate.Text = value; }
        }

        public string LateDays
        {
            get { return DaysLate.Text; }
            set { DaysLate.Text = value; }
        }

        public Button Remove => RemoveBtn;
        public PictureBox Seperator => ShowSeperator;
        public PictureBox Seperator2 => ShowSeperator2;
    }
}
