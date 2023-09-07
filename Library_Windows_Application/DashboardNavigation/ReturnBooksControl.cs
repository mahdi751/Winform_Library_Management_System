using Library_Windows_Application.Assemblers;
using Library_Windows_Application.BorrowedBooksControl_Components;
using Library_Windows_Application.DTOs;
using Library_Windows_Application.Models;
using Library_Windows_Application.Properties;
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
    public partial class ReturnBooksControl : UserControl
    {
        private Membership _membership;
        private BorrowAssembler borrowedBooksAssembler = new BorrowAssembler();
        private BookAssembler bookAssembler = new BookAssembler();
        private Image[] images = new Image[4];
        public ReturnBooksControl(Membership membership)
        {
            InitializeComponent();
            _membership = membership;

            StoreImages();
            _ = ReLoad();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public async Task ReLoad()
        {

            CurrentBorrowPanel.Controls.Clear();
            CurrentBorrowPanel.AutoScroll = true;
            await populateCurrentlyBorrowed();

        }

        private async Task populateCurrentlyBorrowed()
        {
            if (_membership != null)
            {
                IEnumerable<BorrowDetailsDTO> unReturnedBorrowedBooks = await borrowedBooksAssembler.GetUnReturnedBorrowedBooks(_membership.MembershipID);
                int counter = 0;
                int ImageIndex = 0;

                if (unReturnedBorrowedBooks.Any())
                {
                    counter = 0;
                    ImageIndex = 0;
                    CurrentUnReturnedBorrowedBooksDisplay[] currentUnReturnedBorrowedBooksDisplays = new CurrentUnReturnedBorrowedBooksDisplay[unReturnedBorrowedBooks.Count()]; // Use unReturnedBorrowedBooks.Count() here
                    DateTime ReturnDate;
                    int day, month, year;
                    int pday, pmonth, pyear;

                    foreach (var book in unReturnedBorrowedBooks)
                    {
                        ReturnDate = book.ReturnDate;
                        day = ReturnDate.Day;
                        month = ReturnDate.Month;
                        year = ReturnDate.Year;

                        DateTime pickup = book.PickupDate;
                        pday = pickup.Day;
                        pmonth = pickup.Month;
                        pyear = pickup.Year;

                        string pickupDate = "Borrowed in " + $" {pday:D2}/{pmonth:D2}/{pyear}";

                        string notReturned = "Return before " + $" {day:D2}/{month:D2}/{year}";

                        if (ImageIndex == 4)
                            ImageIndex = 0;

                        currentUnReturnedBorrowedBooksDisplays[counter] = new CurrentUnReturnedBorrowedBooksDisplay
                        {
                            Image = images[ImageIndex],
                            BookTitle = book.Booktitle,
                            Genre = book.Genre,
                            Author = "\"" + book.AuthorName + "\"",
                            ReturnLabel = notReturned,
                            BorrowDateLabel = pickupDate
                        };

                        if (counter % 3 == 0)
                        {
                            currentUnReturnedBorrowedBooksDisplays[counter].Margin = new Padding(80, 3, 3, 3);
                        }

                        CurrentBorrowPanel.Controls.Add(currentUnReturnedBorrowedBooksDisplays[counter]);
                        currentUnReturnedBorrowedBooksDisplays[counter].ReturnButton.Click += async (sender, e) => await HandleReturnButtonClick(sender, book, _membership);

                        counter++;
                        ImageIndex++;
                    }
                }
                else
                {
                    NoCurrentItems();
                }
            }
        }

        private void NoCurrentItems()
        {
            Label errorLabel = new Label();
            errorLabel.Text = "No Books to Return!";
            errorLabel.ForeColor = Color.Blue;
            errorLabel.AutoSize = false;
            errorLabel.Width = label1.Width;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.Font = new Font(errorLabel.Font.FontFamily, 10, FontStyle.Bold);

            CurrentBorrowPanel.AutoScroll = false;
            CurrentBorrowPanel.Controls.Add(errorLabel);
        }

        private async Task HandleReturnButtonClick(object sender, BorrowDetailsDTO book, Membership membership)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to return \""+book.Booktitle+"\" book?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                foreach (Control control in CurrentBorrowPanel.Controls)
                {
                    if (control is CurrentUnReturnedBorrowedBooksDisplay display)
                    {
                        display.ReturnButton.Enabled = false;
                    }
                }

                await Task.Delay(500);

                if(book.Fine != 0 )
                {
                    MessageBox.Show("There are some unpaid fines!\nPay it to return this book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foreach (Control control in CurrentBorrowPanel.Controls)
                    {
                        if (control is CurrentUnReturnedBorrowedBooksDisplay display)
                        {
                            display.ReturnButton.Enabled = true;
                        }
                    }
                }
                else
                {
                    BorrowDTO borrowDTO = new BorrowDTO
                    {
                        Book_BookID = book.Bookid,
                        Membership_MembershipID = membership.MembershipID
                    };

                    var success = await borrowedBooksAssembler.ReturnBorrowedBook(borrowDTO);
                    if (success)
                    {
                        MessageBox.Show("Book Returned Successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _ = ReLoad();
                    }
                    else
                    {
                        MessageBox.Show("Failed to return your book!\nTry again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        foreach (Control control in CurrentBorrowPanel.Controls)
                        {
                            if (control is CurrentUnReturnedBorrowedBooksDisplay display)
                            {
                                display.ReturnButton.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void StoreImages()
        {
            images[0] = Resources.BookDisplay1;
            images[1] = Resources.BookDisplay2;
            images[2] = Resources.BookDisplay3;
            images[3] = Resources.BookDisplay5;
        }

        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            await ReLoad();
        }
    }
}
