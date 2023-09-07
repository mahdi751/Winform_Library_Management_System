using Library_Windows_Application.Assemblers;
using Library_Windows_Application.BorrowedBooksControl_Components;
using Library_Windows_Application.Dashboard_Controls;
using Library_Windows_Application.DTOs;
using Library_Windows_Application.Models;
using Library_Windows_Application.Properties;

namespace Library_Windows_Application.BooksNavigation
{
    public partial class ReviewControl : UserControl
    {
        private Panel _bookFormPanel;
        private BookDetailsDTO _book;
        private Membership _membership;
        private MembershipAssembler membershipAssembler = new MembershipAssembler();
        private ReviewAssembler reviewAssembler = new ReviewAssembler();
        private int rating = 1;

        public ReviewControl()
        {
            InitializeComponent();
            CommentText.Padding = new Padding(10);
        }


        public void setReviewControlComponent(Panel bookFormPanel, BookDetailsDTO book, Membership membership)
        {
            _bookFormPanel = bookFormPanel;
            _book = book;
            _membership = membership;

            BookName.Text = _book.Booktitle;
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

        public async void LoadReviews()
        {
            await DisplayAverageBookRating(_book.Bookid);
            if (_book != null)
            {
                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Clear();
                await populateReviews();
            }
        }

        private async Task populateReviews()
        {
            IEnumerable<ReviewDetailsDTO> reviews = await reviewAssembler.GetAllReviews(_book.Bookid, errorLabel);
            if (reviews.Any())
            {
                int counter = 0;
                int rating;
                ReviewsDisplay[] reviewsDisplay = new ReviewsDisplay[reviews.Count()];
                foreach (var review in reviews)
                {
                    DateTime reviewDate = review.ReviewDate;
                    int day = reviewDate.Day;
                    int month = reviewDate.Month;
                    int year = reviewDate.Year;

                    rating = review.Rating;

                    reviewsDisplay[counter] = new ReviewsDisplay
                    {
                        UserName = review.Username,
                        Rating = review.Rating,
                        ReviewDate = $"{day:D2}/{month:D2}/{year}",
                        Comment = review.Comment
                    };

                    FlowLayoutPanel starsPanel = reviewsDisplay[counter].StarsPanel;
                    for (int i = 0; i < rating; i++)
                    {
                        PictureBox star = new PictureBox();
                        star.Width = 27;
                        star.Height = 27;
                        star.Image = Resources.star;
                        star.SizeMode = PictureBoxSizeMode.Zoom;

                        starsPanel.Controls.Add(star);
                    }

                    flowLayoutPanel1.Controls.Add(reviewsDisplay[counter]);
                    int horizontalMargin = (flowLayoutPanel1.Width - reviewsDisplay[counter].Width) / 2;
                    reviewsDisplay[counter].Margin = new Padding(horizontalMargin, reviewsDisplay[counter].Margin.Top, horizontalMargin, reviewsDisplay[counter].Margin.Bottom);

                    counter++;
                }
            }
            else
            {
                NoHistoryItems();
            }

        }

        private void NoHistoryItems()
        {
            Label errorLabel2 = new Label();
            errorLabel2.Text = "No reviews where found!";
            errorLabel2.ForeColor = Color.Blue;
            errorLabel2.AutoSize = false;
            errorLabel2.Width = flowLayoutPanel1.Width;
            errorLabel2.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel2.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel2.Font = new Font(errorLabel2.Font.FontFamily, 10, FontStyle.Bold);

            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.Controls.Add(errorLabel2);
        }

        private async void AddReview_Click(object sender, EventArgs e)
        {
            if (CommentText.Text.Count() == 0 || CommentText.Text == "Enter your comment . . .")
            {
                NullComment.Visible = true;
                CommentError.Visible = false;
            }
            else
            if (CommentText.Text.Count() < 301 && CommentText.Text.Count() > 0 && CommentText.Text != "Enter your comment . . .")
            {
                CommentError.Visible = false;
                NullComment.Visible = false;

                ReviewDTO reviewDTO = new ReviewDTO()
                {
                    BookID = _book.Bookid,
                    MembershipID = _membership.MembershipID,
                    Comment = CommentText.Text,
                    Rating = rating
                };
                var addedReview = await reviewAssembler.AddReviewControl(reviewDTO, errorLabel);
                if (addedReview)
                {
                    DialogResult result = MessageBox.Show("Review added Successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    flowLayoutPanel1.Controls.Clear();
                    CommentText.Text = "";
                    rating = 1;
                    UpdateRating();

                    await DisplayAverageBookRating(_book.Bookid);
                    await populateReviews();
                }
                else
                {
                    if (errorLabel.Text == "")
                    {
                        errorLabel.Visible = true;
                        errorLabel.Text = "Review not added! Try again!";
                    }

                    errorLabel.Visible = true;
                }
            }
            else
            {
                CommentError.Visible = true;
                NullComment.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            rating = 1;
            UpdateRating();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            rating = 2;
            UpdateRating();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            rating = 3;
            UpdateRating();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            rating = 4;
            UpdateRating();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            rating = 5;
            UpdateRating();
        }

        private void UpdateRating()
        {
            List<PictureBox> stars = new List<PictureBox> { pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };

            for (int i = 0; i < stars.Count; i++)
            {
                if (i < rating)
                {
                    stars[i].Image = Resources.star;
                }
                else
                {
                    stars[i].Image = Resources.emptyStar;
                }
            }
        }

        private void CommentEnter(object sender, EventArgs e)
        {
            if (CommentText.Text == "Enter your comment . . .")
            {
                CommentText.Text = "";
                CommentText.ForeColor = Color.White;
            }
        }

        private void CommentLeave(object sender, EventArgs e)
        {
            if (CommentText.Text == "")
            {
                CommentText.Text = "Enter your comment . . .";
                CommentText.ForeColor = Color.Gray;
            }
        }

        private async Task DisplayAverageBookRating(int bookid)
        {
            List<PictureBox> stars = new List<PictureBox>
                {
                    pictureBox12,
                    pictureBox13,
                    pictureBox14,
                    pictureBox15,
                    pictureBox16
                };

            var avrRating = await reviewAssembler.GetBookAverageRating(bookid);
            if (avrRating == -1)
            {
                DisplayInvalid.Text = "Average Rating Invalid!";
                for (int i = 0; i < stars.Count; i++)
                {
                    stars[i].Image = Resources.emptyStar;
                }
            }
            else
            {
                DisplayInvalid.Text = "Book average rating";

                for (int i = 0; i < stars.Count; i++)
                {
                    if (i < avrRating)
                    {
                        stars[i].Image = Resources.star;
                    }
                    else
                    {
                        stars[i].Image = Resources.emptyStar;
                    }
                }
            }
        }

        private void CommentText_TextChanged(object sender, EventArgs e)
        {
            totalChar.Text = CommentText.Text.Count() + "";
        }
    }
}
