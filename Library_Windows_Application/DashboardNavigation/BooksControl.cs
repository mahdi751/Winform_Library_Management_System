using Library_Windows_Application.Assemblers;
using Library_Windows_Application.BooksNavigation;
using Library_Windows_Application.DTOs;
using Library_Windows_Application.Models;
using Library_Windows_Application.Properties;
using System.Diagnostics.Metrics;

namespace Library_Windows_Application.Dashboard_Controls
{
    public partial class BooksControl : UserControl
    {
        private BookAssembler bookAssembler = new BookAssembler();
        private MembershipAssembler membershipAssembler = new MembershipAssembler();
        private BorrowAssembler borrowedBooksAssembler = new BorrowAssembler();

        private NavigationControl navigationControl;
        private BorrowControl borrowControl = new BorrowControl();
        private ReviewControl reviewControl = new ReviewControl();

        private Panel _BookFormPanel;
        private Membership _membership;
        private string option = "Title";
        private IEnumerable<BookDetailsDTO> books;
        private Image[] images = new Image[4];
        private bool isBorrowPossible = false;

        public BooksControl()
        {
            InitializeComponent();
        }

        public BooksControl(Panel BookFormPanel, Membership membership)
        {
            InitializeComponent();
            _BookFormPanel = BookFormPanel;
            _membership = membership;

            InitializeNavigationControls();
            StoreBookImages();
            _ = ReLoad();

        }

        private async Task BorrowValidation()
        {
            var MembershipDate = _membership.EndDate;
            var RemainingBorrowAbility = await membershipAssembler.GetMembershipRemainingBorrowAbility(_membership.MembershipID);
            if (DateTime.Today > MembershipDate)
            {
                isBorrowPossible = false;
                memberhsipLabel.Visible = true;
                memberhsipLabel.Text = "Your Membership is out dated!";
            }
            else
            {
                if (RemainingBorrowAbility == 0)
                {
                    isBorrowPossible = false;
                    memberhsipLabel.Visible = true;
                    memberhsipLabel.Text = "Renew or Upgrade your membership to borrow books!";
                }
                else
                {
                    memberhsipLabel.Text = "";
                    memberhsipLabel.Visible = false;
                    isBorrowPossible = true;
                }
            }



        }

        public async Task ReLoad()
        {
            await BorrowValidation();
            SearchBox.Text = "Search";

            flowLayoutPanel1.Focus();
            flowLayoutPanel1.Controls.Clear();
            books = await bookAssembler.GetBooksControl(ErrorLabel);

            populateItems();
        }

        private void OnFilterChange(object sender, EventArgs e)
        {
            string selectedOption = FilterBox.SelectedItem.ToString();
            if (selectedOption == "Title")
            {
                option = "Title";
            }
            else if (selectedOption == "Author")
            {
                option = "Author";
            }
            else if (selectedOption == "Genre")
            {
                option = "Genre";
            }

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void OnEnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                await CallAPI();
            }
        }

        private async void SearchClick(object sender, EventArgs e)
        {
            await CallAPI();
        }

        private void StoreBookImages()
        {
            images[0] = Resources.BookDisplay1;
            images[1] = Resources.BookDisplay2;
            images[2] = Resources.BookDisplay3;
            images[3] = Resources.BookDisplay5;
        }
        private async Task CallAPI()
        {
            string searchText = SearchBox.Text;

            if (searchText == "" || searchText == "Search")
            {
                books = await bookAssembler.GetBooksControl(ErrorLabel);
            }
            else
            {
                switch (option)
                {
                    case "Title":
                        books = await bookAssembler.GetBooksByTitleControl(searchText, ErrorLabel);
                        break;
                    case "Author":
                        books = await bookAssembler.GetBooksByAuthorNameControl(searchText, ErrorLabel);
                        break;
                    case "Genre":
                        books = await bookAssembler.GetBooksByGenreControl(searchText, ErrorLabel);
                        break;
                    default:
                        books = await bookAssembler.GetBooksControl(ErrorLabel);
                        break;
                }
            }

            flowLayoutPanel1.Controls.Clear();
            populateItems();
        }
        public void populateItems()
        {
            if (books.Any())
            {
                ErrorLabel.Visible = false;
                int counter = 0;
                int ImageIndex = 0;
                BookListingControl[] booksListing = new BookListingControl[books.Count()];

                foreach (var book in books)
                {

                    DateTime publicationDate = book.Publicationdate;
                    int day = publicationDate.Day;
                    int month = publicationDate.Month;
                    int year = publicationDate.Year;

                    if (ImageIndex == 4)
                        ImageIndex = 0;

                    booksListing[counter] = new BookListingControl
                    {
                        Image = images[ImageIndex],
                        Title = book.Booktitle,
                        Quantity = book.AvailableQuantity,
                        PublishDate = $"{day:D2}/{month:D2}/{year}",
                        Publisher = book.Publishername,
                        Genre = book.Genre,
                        Authorname = "\"" + book.AuthorName + "\"",
                    };

                    booksListing[counter].ReviewButton.Click += (sender, e) => HandleReviewButtonClick(sender, book);
                    booksListing[counter].BorrowButton.Click += async (sender, e) => await HandleBorrowButtonClick(sender, book);

                    if (!isBorrowPossible)
                        booksListing[counter].BorrowButton.Enabled = false;

                    if (book.AvailableQuantity == 0)
                    {
                        booksListing[counter].BorrowButton.Enabled = false;
                        booksListing[counter].Availablelabel.ForeColor = Color.Maroon;
                    }
                    else
                        booksListing[counter].Availablelabel.ForeColor = Color.SeaGreen;



                    flowLayoutPanel1.Controls.Add(booksListing[counter]);
                    counter++;
                    ImageIndex++;
                }

            }
            else
            {
                NoCurrentItems();

                if (memberhsipLabel.Visible == true)
                {
                    ErrorLabel.Visible = false;
                }
            }
        }

        private void NoCurrentItems()
        {
            Label errorLabel = new Label();
            errorLabel.Text = "No items where found!";
            errorLabel.ForeColor = Color.Blue;
            errorLabel.AutoSize = false;
            errorLabel.Width = label2.Width;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.Font = new Font(errorLabel.Font.FontFamily, 10, FontStyle.Bold);

            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.Controls.Add(errorLabel);
        }

        private void InitializeNavigationControls()
        {
            List<UserControl> userControls = new List<UserControl>()
            {
                borrowControl,
                reviewControl
            };

            navigationControl = new NavigationControl(userControls, _BookFormPanel);
        }

        private async Task HandleBorrowButtonClick(object sender, BookDetailsDTO book)
        {

            Borrow borrowRec = await borrowedBooksAssembler.GetBorrowRecordByMembership(book.Bookid, _membership.MembershipID);
            DialogResult result = MessageBox.Show("Are you sure you want to borrow \" " + book.Booktitle + " \" book?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (borrowRec != null)
                {
                    if (borrowRec.IsReturned)
                    {
                        int remainingQuantity = await bookAssembler.GetBookRemainingQuantity(borrowRec.Book_BookID);
                        if (remainingQuantity > 0)
                        {
                            BorrowDTO borrowDto = new BorrowDTO()
                            {
                                Book_BookID = borrowRec.Book_BookID,
                                Membership_MembershipID = borrowRec.Membership_MembershipID
                            };
                            var success = await borrowedBooksAssembler.UpdateBorrowBookRecord(borrowDto);

                            if (success)
                            {
                                DialogResult borrowResult = MessageBox.Show("Book borrowed Successfully!", "Success", MessageBoxButtons.OK , MessageBoxIcon.Information);
                                await ReLoad();
                            }
                            else
                            {
                                DialogResult error = MessageBox.Show("Error occured while borrowing the book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            DialogResult error = MessageBox.Show("Book not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            await ReLoad();
                        }
                    }
                    else
                    {
                        DialogResult resultt = MessageBox.Show("\" " + book.Booktitle + " \" already borrowed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    BorrowDTO borrowDto = new BorrowDTO()
                    {
                        Book_BookID = book.Bookid,
                        Membership_MembershipID = _membership.MembershipID
                    };
                    var success = await borrowedBooksAssembler.BorrowBook(borrowDto);

                    if (success)
                    {
                        DialogResult borrowResult = MessageBox.Show("Book borrowed Successfully!", "Success", MessageBoxButtons.OK);
                        if (borrowResult == DialogResult.OK || borrowResult == DialogResult.Abort)
                        {
                            _ = ReLoad();
                        }
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("Error occured while borrowing the book!", "Error", MessageBoxButtons.OK);
                    }
                }
            }

        }

        private void HandleReviewButtonClick(object sender, BookDetailsDTO book)
        {
            reviewControl.setReviewControlComponent(_BookFormPanel, book, _membership);
            navigationControl.Display(1);
            reviewControl.LoadReviews();
        }

        private void SearchEnter(object sender, EventArgs e)
        {
            if (SearchBox.Text.Equals("Search"))
            {
                SearchBox.Text = string.Empty;
                SearchBox.ForeColor = Color.Blue;
            }
        }

        private void SearchLeave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                SearchBox.Text = "Search";
                SearchBox.ForeColor = Color.Gray;
            }
        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            await ReLoad();
        }
    }
}
