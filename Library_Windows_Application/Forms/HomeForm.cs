using Library_Windows_Application.Assemblers;
using Library_Windows_Application.BooksNavigation;
using Library_Windows_Application.Dashboard_Controls;
using Library_Windows_Application.Models;

namespace Library_Windows_Application.Forms
{
    public partial class HomeForm : Form
    {
        private Membership _membership = new Membership();

        private AccountAssembler accountAssembler = new AccountAssembler();

        private NavigationControl navigationControl;
        private string usernameReturned;

        private BooksControl booksControl;
        private BorrowedBooks borrowControl;
        private ReturnBooksControl returnBooksControl;
        private MembershipControl membershipControl;
        private PaymentHistoryControl paymentHistoryControl;

        private System.Windows.Forms.Timer animationTimer;
        private double currentOpacity;

        public HomeForm()
        {
            InitializeComponent();
        }

        public HomeForm(Membership membership)
        {
            InitializeComponent();
            InitializeAnimation();
            _membership = membership;
            LoadUsername();

            InitializeControls();
            InitializeNavigationControls();
            AttachEvents();
        }

        private void InitializeControls()
        {
            booksControl = new BooksControl(Channel, _membership);
            borrowControl = new BorrowedBooks(_membership);
            returnBooksControl = new ReturnBooksControl(_membership);
            membershipControl = new MembershipControl(_membership, this);
            paymentHistoryControl = new PaymentHistoryControl(_membership);
        }

        private void InitializeNavigationControls()
        {
            List<UserControl> userControls = new List<UserControl>()
            {
                booksControl,
                membershipControl,
                returnBooksControl,
                borrowControl,
                paymentHistoryControl
            };

            navigationControl = new NavigationControl(userControls, Channel);

            navigationControl.Display(0);
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void LoadUsername()
        {
            usernameReturned = await accountAssembler.GetUsernameControl(_membership.User_UserID);
            if (usernameReturned != null)
            {
                UsernameLabel.Text = usernameReturned;
            }
            else
            {
                DialogResult result = MessageBox.Show("Something went wrong!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();
            }
        }

        private void AttachEvents()
        {
            navigtionMenu1.OnItemClick.Add("Books", async (button1) =>
            {
                await booksControl.ReLoad();
                navigationControl.Display(0);
            });

            navigtionMenu1.OnItemClick.Add("Membership", async (button2) =>
            {
                await membershipControl.Reload();
                navigationControl.Display(1);
            });

            navigtionMenu1.OnItemClick.Add("Return Books", async (button3) =>
            {
                await returnBooksControl.ReLoad();
                navigationControl.Display(2);
            });

            navigtionMenu1.OnItemClick.Add("Borrowed Books", async (button4) =>
            {
                await borrowControl.ReLoad();
                navigationControl.Display(3);
            });

            navigtionMenu1.OnItemClick.Add("Late Fines", async (button5) =>
            {
                await paymentHistoryControl.ReLoad();
                navigationControl.Display(4);
            });

            navigtionMenu1.OnItemClick.Add("Logout", (button6) =>
            {
                logoutClick();
            });
        }

        private void logoutClick()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (result == DialogResult.OK)
                {
                    this.Hide();

                    LoginForm login = new LoginForm();
                    login.FormClosed += (s, args) => this.Close();
                    login.Show();
                }
            }
        }
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            currentOpacity += 0.05;

            if (currentOpacity >= 1)
            {
                animationTimer.Stop();
                Opacity = 1;
            }
            else
            {
                Opacity = currentOpacity;
            }
        }

        private void InitializeAnimation()
        {
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 10;
            animationTimer.Tick += AnimationTimer_Tick;

            Opacity = 0;
            animationTimer.Start();
        }
    }
}
