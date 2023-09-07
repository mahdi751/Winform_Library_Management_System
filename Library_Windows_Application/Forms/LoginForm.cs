using Library_Windows_Application.Assemblers;
using Library_Windows_Application.DTOs;
using Library_Windows_Application.Forms;
using Library_Windows_Application.Models;

namespace Library_Windows_Application
{
    public partial class LoginForm : Form
    {
        private Membership membership;
        private bool isDragging;
        private bool ShowSignInForm = false;
        private Point lastMousePosition;
        private bool notVisible = true;
        private AccountAssembler accountAssembler = new AccountAssembler();
        private MembershipAssembler membershipAssembler = new MembershipAssembler();
        private bool areCredentialsValid = false;
        private System.Windows.Forms.Timer animationTimer;
        private double currentOpacity;

        public LoginForm()
        {

            InitializeComponent();

            /*pbar.Value = 0;
            loadingTime.Enabled = false;*/

            InitializeAnimation();
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void onMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void UsernameText_Leave(object sender, EventArgs e)
        {
            if (UsernameText.Text == "")
            {
                UsernameText.Text = "Username";
                UsernameText.ForeColor = Color.Gray;
            }
        }

        private void UsernameText_Enter(object sender, EventArgs e)
        {
            if (UsernameText.Text.Equals("Username"))
            {
                UsernameText.Text = string.Empty;
                UsernameText.ForeColor = Color.Blue;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordText.Text == "")
            {
                PasswordText.Text = "Password";
                PasswordText.UseSystemPasswordChar = false;
                PasswordText.ForeColor = Color.Gray;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text.Equals("Password"))
            {
                PasswordText.Text = string.Empty;
                PasswordText.UseSystemPasswordChar = true;
                PasswordText.ForeColor = Color.Blue;
            }
        }

        private void Visibility_Click(object sender, EventArgs e)
        {
            if (PasswordText.Text != "Password")
            {
                if (notVisible)
                {
                    pictureBox13.Image = Properties.Resources.view;
                    notVisible = false;
                    PasswordText.UseSystemPasswordChar = false;
                }
                else
                {
                    pictureBox13.Image = Properties.Resources.hide;
                    notVisible = true;
                    PasswordText.UseSystemPasswordChar = true;
                }
            }
        }

        private void SigninCLick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableFormComponent();
            this.Hide();

            RegisterForm registerForm = new RegisterForm();
            registerForm.FormClosed += (s, args) => this.Close();
            registerForm.Show();
            EnableFormComponent();
            //EnableLoading();
        }

        private async void LoginClick(object sender, EventArgs e)
        {
            DisableFormComponent();
            //EnableLoading();

            var username = UsernameText.Text;
            var password = PasswordText.Text;

            if (username == "" || password == "" || username == "Username" || password == "Password")
            {
                ErrorLabel.Text = "Fill out all nedded credentials!";
                EnableFormComponent();
            }
            else
            {
                LoginDTO loginDTO = new LoginDTO
                {
                    Username = username,
                    Password = password
                };

                var user = await accountAssembler.LoginControl(loginDTO, ErrorLabel);
                if (user != null)
                {
                    membership = await membershipAssembler.GetMembershipControl(user.UserID, ErrorLabel);

                    if (membership != null)
                    {
                        this.Hide();

                        HomeForm home = new HomeForm(membership);
                        home.FormClosed += (s, args) => this.Close();
                        home.Show();
                    }
                }
                else
                {
                    EnableFormComponent();
                }
            }
        }

        /*private void loading(object sender, EventArgs e)
        {
            pbar.Value += 1;
            pbar.Text = pbar.Value.ToString() + "%";
            if (pbar.Value == 100)
            {
                DisableLoading();
                EnableFormComponent();

                if (areCredentialsValid)
                {

                    this.Hide();

                    HomeForm home = new HomeForm(membership);
                    home.FormClosed += (s, args) => this.Close();
                    home.Show();

                }
                else if (ShowSignInForm)
                {

                    this.Hide();

                    RegisterForm registerForm = new RegisterForm();
                    registerForm.FormClosed += (s, args) => this.Close();
                    registerForm.Show();
                }
            }
        }*/

        /*private void EnableLoading()
        {
            pbar.Visible = true;
            loadingTime.Enabled = true;
            loadingLabel.Visible = true;
        }

        private void DisableLoading()
        {
            loadingTime.Enabled = false;
            pbar.Visible = false;
            pbar.Value = 0;
            loadingLabel.Visible = false;
        }*/

        private void DisableFormComponent()
        {
            ErrorLabel.Visible = false;
            LoginBtn.Enabled = false;
            linkLabel1.Enabled = false;
        }

        private void EnableFormComponent()
        {
            ErrorLabel.Visible = true;
            LoginBtn.Enabled = true;
            linkLabel1.Enabled = true;
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