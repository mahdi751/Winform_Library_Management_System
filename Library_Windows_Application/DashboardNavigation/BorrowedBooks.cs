using Library_Windows_Application.Assemblers;
using Library_Windows_Application.BorrowedBooksControl_Components;
using Library_Windows_Application.DTOs;
using Library_Windows_Application.Models;
using Library_Windows_Application.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Windows_Application.Dashboard_Controls
{
    public partial class BorrowedBooks : UserControl
    {
        private Membership _membership;
        private BorrowAssembler borrowedBooksAssembler = new BorrowAssembler();
        private BookAssembler bookAssembler = new BookAssembler();
        private Image[] images = new Image[4];


        public BorrowedBooks(Membership membership)
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
            CurrentBorrowPanel.AutoSize = false;
            CurrentBorrowPanel.Height = 250;
            await populateCurrentlyBorrowed();


            BorrowHistoryPanel.Controls.Clear();
            BorrowHistoryPanel.AutoScroll = true;
            await populateAllBorrowed();

        }

        private void StoreImages()
        {
            images[0] = Resources.BookDisplay1;
            images[1] = Resources.BookDisplay2;
            images[2] = Resources.BookDisplay3;
            images[3] = Resources.BookDisplay5;
        }

        private async Task populateAllBorrowed()
        {
            if (_membership.User_UserID != null)
            {
                IEnumerable<BorrowDetailsDTO> borrowedBooks = await borrowedBooksAssembler.GetAllBorrowedBooks(_membership.User_UserID);

                if (borrowedBooks.Any())
                {
                    BorrowHistoryPanel.AutoScroll = true;

                    int counter = 0;
                    int ImageIndex = 0;
                    BorrowedBooksDisplay[] borrowedDisplay = new BorrowedBooksDisplay[999999];
                    int pday, pmonth, pyear;
                    int day, month, year;
                    bool returned;

                    foreach (var book in borrowedBooks)
                    {
                        string isReturned = "Returned in";
                        string notReturned = "Return before";

                        if (ImageIndex == 4)
                            ImageIndex = 0;

                        if (book.IsReturned)
                        {
                            returned = true;

                            DateTime returnedDate = book.ReturnedDate;
                            day = returnedDate.Day;
                            month = returnedDate.Month;
                            year = returnedDate.Year;

                            isReturned += $" {day:D2}/{month:D2}/{year}";

                        }
                        else
                        {
                            returned = false;

                            DateTime returnDate = book.ReturnDate;

                            day = returnDate.Day;
                            month = returnDate.Month;
                            year = returnDate.Year;

                            notReturned += $" {day:D2}/{month:D2}/{year}";
                        }

                        DateTime pickup = book.PickupDate;
                        pday = pickup.Day;
                        pmonth = pickup.Month;
                        pyear = pickup.Year;

                        string pickupDate = "Borrowed in " + $" {pday:D2}/{pmonth:D2}/{pyear}";

                        borrowedDisplay[counter] = new BorrowedBooksDisplay
                        {
                            Image = images[ImageIndex],
                            BookTitle = book.Booktitle,
                            Genre = book.Genre,
                            Author = "\"" + book.AuthorName + "\"",
                            ReturnLabel = returned ? isReturned : notReturned,
                            Status = returned ? Resources.greencircle : Resources.redcircle,
                            BorrowDateLabel = pickupDate
                        };

                        if (returned)
                            borrowedDisplay[counter].BackColor = Color.SkyBlue;
                        else
                            borrowedDisplay[counter].BackColor = Color.MediumSpringGreen;

                        if (counter % 3 == 0)
                        {
                            borrowedDisplay[counter].Margin = new Padding(80, 3, 3, 3);
                        }

                        BorrowHistoryPanel.Controls.Add(borrowedDisplay[counter]);

                        counter++;
                        ImageIndex++;
                    }

                }
                else
                {
                    NoHistoryItems();
                }
            }

        }

        private async Task populateCurrentlyBorrowed()
        {
            if (_membership.User_UserID != null)
            {
                IEnumerable<BorrowDetailsDTO> returnedBorrowedBooks = await borrowedBooksAssembler.GetReturnedBorrowedBooks(_membership.MembershipID);
                IEnumerable<BorrowDetailsDTO> unReturnedBorrowedBooks = await borrowedBooksAssembler.GetUnReturnedBorrowedBooks(_membership.MembershipID);
                int counter1 = 0;
                int ImageIndex = 0;

                if (unReturnedBorrowedBooks.Any())
                {
                    CurrentBorrowPanel.Controls.Clear();
                    counter1 = 0;
                    ImageIndex = 0;
                    CurrentUnReturnedBorrowedBooksDisplay[] currentUnReturnedBorrowedBooksDisplays = new CurrentUnReturnedBorrowedBooksDisplay[unReturnedBorrowedBooks.Count()]; // Use unReturnedBorrowedBooks.Count() here
                    DateTime ReturnDate;
                    int pday, pmonth, pyear;
                    int day, month, year;

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

                        currentUnReturnedBorrowedBooksDisplays[counter1] = new CurrentUnReturnedBorrowedBooksDisplay
                        {
                            Image = images[ImageIndex],
                            BookTitle = book.Booktitle,
                            Genre = book.Genre,
                            Author = "\"" + book.AuthorName + "\"",
                            ReturnLabel = notReturned,
                            BorrowDateLabel = pickupDate
                        };

                        if (counter1 % 3 == 0)
                        {
                            currentUnReturnedBorrowedBooksDisplays[counter1].Margin = new Padding(80, 3, 3, 3);
                        }

                        CurrentBorrowPanel.Controls.Add(currentUnReturnedBorrowedBooksDisplays[counter1]);
                        currentUnReturnedBorrowedBooksDisplays[counter1].ReturnButton.Click += (sender, e) => HandleReturnButtonClick(sender, book, _membership);

                        counter1++;
                        ImageIndex++;
                    }
                }
                if (returnedBorrowedBooks.Any())
                {
                    int counter2 = 0;
                    CurrentReturnedBorrowedBooksDisplay[] currentReturnedBorrowedBooksDisplays = new CurrentReturnedBorrowedBooksDisplay[returnedBorrowedBooks.Count() + counter1];
                    int day, month, year;
                    int pday, pmonth, pyear;

                    foreach (var book in returnedBorrowedBooks)
                    {
                        string isReturned = "Returned in";

                        DateTime returnedDate = book.ReturnedDate;
                        day = returnedDate.Day;
                        month = returnedDate.Month;
                        year = returnedDate.Year;

                        DateTime pickup = book.PickupDate;
                        pday = pickup.Day;
                        pmonth = pickup.Month;
                        pyear = pickup.Year;

                        string pickupDate = "Borrowed in " + $" {pday:D2}/{pmonth:D2}/{pyear}";

                        isReturned = "Returned in " + $" {day:D2}/{month:D2}/{year}";

                        if (ImageIndex == 4)
                            ImageIndex = 0;

                        currentReturnedBorrowedBooksDisplays[counter1] = new CurrentReturnedBorrowedBooksDisplay
                        {
                            Image = images[ImageIndex],
                            BookTitle = book.Booktitle,
                            Genre = book.Genre,
                            Author = "\"" + book.AuthorName + "\"",
                            ReturnLabel = isReturned,
                            BorrowDateLabel = pickupDate
                        };


                        if (counter1 % 3 == 0)
                        {
                            currentReturnedBorrowedBooksDisplays[counter1].Margin = new Padding(80, 3, 3, 3);
                        }



                        CurrentBorrowPanel.Controls.Add(currentReturnedBorrowedBooksDisplays[counter1]);

                        counter1++;
                        ImageIndex++;
                    }
                }
                else if (returnedBorrowedBooks.Count() == 0 && unReturnedBorrowedBooks.Count() == 0)
                {
                    NoCurrentItems();
                }
            }
            else
            {
                NoCurrentItems();
            }
        }

        private void NoCurrentItems()
        {
            Label errorLabel = new Label();
            errorLabel.Text = "No items where found!";
            errorLabel.ForeColor = Color.Blue;
            errorLabel.AutoSize = false;
            errorLabel.Width = label1.Width;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.Font = new Font(errorLabel.Font.FontFamily, 10, FontStyle.Bold);

            CurrentBorrowPanel.AutoSize = true;
            CurrentBorrowPanel.AutoScroll = false;
            CurrentBorrowPanel.Controls.Add(errorLabel);
        }

        private void NoHistoryItems()
        {
            Label errorLabel2 = new Label();
            errorLabel2.Text = "No items where found!";
            errorLabel2.ForeColor = Color.Blue;
            errorLabel2.AutoSize = false;
            errorLabel2.Width = BorrowHistoryPanel.Width;
            errorLabel2.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel2.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel2.Font = new Font(errorLabel2.Font.FontFamily, 10, FontStyle.Bold);

            BorrowHistoryPanel.AutoScroll = false;
            BorrowHistoryPanel.Controls.Add(errorLabel2);
        }

        private async Task HandleReturnButtonClick(object sender, BorrowDetailsDTO book, Membership membership)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to return \"" + book.Booktitle + "\" book?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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

                if (book.Fine != 0)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ReLoad();
        }
    }
}
