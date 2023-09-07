using Library_Windows_Application.Dashboard_Controls;
using Library_Windows_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Windows_Application.BooksNavigation
{
    public partial class BorrowControl : UserControl
    {
        private Panel _bookFormPanel;
        private Book _book;
        private Membership _membership;
        public BorrowControl()
        {
            InitializeComponent();
        }

        public void setBorrowControlComponent(Panel bookFormPanel, Book book, Membership membership)
        {
            _bookFormPanel = bookFormPanel;
            _book = book;
            _membership = membership;
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            foreach (Control control in _bookFormPanel.Controls)
            {
                if (control is BooksControl)
                {
                    control.BringToFront();
                }
            }
        }
    }
}
