using Library_Windows_Application.Assemblers;
using Library_Windows_Application.DTOs;
using Library_Windows_Application.Models;
using Library_Windows_Application.PaymentControls;
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
    public partial class PaymentHistoryControl : UserControl
    {
        private Membership _membership;
        private decimal fines;
        private Image[] images = new Image[4];
        private FinesDisplayControl[] displayFines;


        private PaymentAssembler paymentAssembler = new PaymentAssembler();
        public PaymentHistoryControl(Membership membership)
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

        private async Task PopulateTotalPayment()
        {
            if (_membership != null)
            {
                fines = await paymentAssembler.GetCurrentTotalOverduePayments(_membership.MembershipID, ErrorLabel);
                if (fines != -1)
                {
                    if(fines == 0)
                    {
                        TotalFines.Text = "To Pay : " + fines + " $";
                        PayAllFinesBtn.Enabled = false;
                        ErrorLabel.Visible = false;
                        NoHistoryItems();
                    }
                    else
                    {
                        PayAllFinesBtn.Enabled = true;
                        ErrorLabel.Visible = false;
                        TotalFines.Text = "To Pay : " + fines + " $";
                        await PopulateItems();
                    }
                }
                else
                {
                    TotalFines.Text = "To Pay : 0 $";
                    ErrorLabel.Visible = true;
                    PayAllFinesBtn.Enabled = false;
                    NoHistoryItems();
                }
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            _ = ReLoad();
        }

        public async Task ReLoad()
        {
            FinesPanel.Controls.Clear();
            FinesPanel.AutoScroll = true;
            FinesPanel.AutoSize = false;
            await PopulateTotalPayment();
        }

        private async Task PopulateItems()
        {
            IEnumerable<OverdueBooksDetailsDTO> overdueBooksDetails = await paymentAssembler.GetOverdueBookDetails(_membership.MembershipID, ErrorLabel);

            if (overdueBooksDetails.Any())
            {
                displayFines = new FinesDisplayControl[overdueBooksDetails.Count() + 1];
                int counter = 0;
                int ImageIndex = 0;

                foreach (var rec in overdueBooksDetails)
                {
                    if (ImageIndex == 4)
                        ImageIndex = 0;

                    int clickedCounter = counter;

                    displayFines[clickedCounter] = new FinesDisplayControl
                    {
                        Image = images[ImageIndex],
                        Title = rec.Title,
                        Authorname = "\"" + rec.Author + "\"",
                        Genre = rec.Genre,
                        Fine = rec.OverdueFine
                    };

                    if (counter % 2 == 0)
                    {
                        displayFines[clickedCounter].Margin = new Padding(125, 15, 15, 15);
                    }

                    FinesPanel.Controls.Add(displayFines[clickedCounter]);

                    displayFines[clickedCounter].DetailsButton.Click += (sender, e) =>
                    {
                        displayFines[clickedCounter].Height += 159;
                        displayFines[clickedCounter].DetailsButton.Enabled = false;
                        DetailsDisplayControl displayDetails = new DetailsDisplayControl
                        {
                            PickupDate = $" {rec.PickUpDate.Day:D2}/{rec.PickUpDate.Month:D2}/{rec.PickUpDate.Year}",
                            Returndate = $" {rec.ReturnDate.Day:D2}/{rec.ReturnDate.Month:D2}/{rec.ReturnDate.Year}",
                            Currentdate = $" {rec.CurrentDate.Day:D2}/{rec.CurrentDate.Month:D2}/{rec.CurrentDate.Year}",
                            LateDays = rec.DaysLate + " days"
                        };

                        displayDetails.Seperator.Visible = true;
                        displayDetails.Seperator2.Visible = true;

                        displayDetails.Remove.Click += (sender, e) =>
                        {
                            displayFines[clickedCounter].DisplayDetailsPanel.Controls.Clear();
                            displayFines[clickedCounter].DetailsButton.Enabled = true;
                            displayFines[clickedCounter].Height = 180;
                        };

                        displayFines[clickedCounter].DisplayDetailsPanel.Controls.Add(displayDetails);
                    };

                    displayFines[clickedCounter].PayFineButton.Click += async (sender, e) => await HandlePayFineButtonClick(sender, rec);

                    counter++;
                    ImageIndex++;
                }
            }
            else
            {
                NoHistoryItems();
            }
        }



        private async Task HandlePayFineButtonClick(object sender, OverdueBooksDetailsDTO overdueRec)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to pay \"" + overdueRec.Title + "\" fine?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                PaymentDTO paymentDTO = new PaymentDTO
                {
                    Fine = fines,
                    BookID = overdueRec.bookID,
                    MembershipID = _membership.MembershipID
                };

                var success = await paymentAssembler.PayBookFines(paymentDTO, ErrorLabel);
                if (success != null)
                {
                    MessageBox.Show("Fine payed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ = ReLoad();
                }
                else
                {
                    MessageBox.Show("Error occured while paying!\n" + ErrorLabel.Text, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void PayAllFines(object sender, EventArgs e)
        {
            if (fines != -1)
            {
                if (fines == 0)
                {
                    PayAllFinesBtn.Enabled = false;
                    NoHistoryItems();
                }
                else
                {
                    PaymentDTO paymentDTO = new PaymentDTO
                    {
                        Fine = fines,
                        BookID = 0,
                        MembershipID = _membership.MembershipID
                    };

                    DialogResult result = MessageBox.Show("Are you sure you want to pay all of your fines?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        var success = await paymentAssembler.PayAllOverdueFines(paymentDTO, ErrorLabel);
                        if (success != null)
                        {
                            MessageBox.Show("Fines payed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _ = ReLoad();
                        }
                        else
                        {
                            MessageBox.Show("Error occured while paying!\n" + ErrorLabel.Text, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void NoHistoryItems()
        {
            ErrorLabel.Visible = false;
            Label errorLabel2 = new Label();
            errorLabel2.Text = "No current Fines to pay!";

            errorLabel2.ForeColor = Color.Blue;
            errorLabel2.AutoSize = false;
            errorLabel2.Width = FinesPanel.Width;
            errorLabel2.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel2.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel2.Font = new Font(errorLabel2.Font.FontFamily, 10, FontStyle.Bold);

            FinesPanel.AutoScroll = false;
            FinesPanel.Controls.Add(errorLabel2);
        }

        private void StoreImages()
        {
            images[0] = Resources.BookDisplay1;
            images[1] = Resources.BookDisplay2;
            images[2] = Resources.BookDisplay3;
            images[3] = Resources.BookDisplay5;
        }
    }
}
