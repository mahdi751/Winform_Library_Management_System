using Library_Windows_Application.Assemblers;
using Library_Windows_Application.DTOs;
using Library_Windows_Application.Models;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Library_Windows_Application.Forms
{
    public partial class RegisterForm : Form
    {
        private bool isDragging;
        private Point lastMousePosition;
        private bool notVisible1 = true;
        private bool notVisible2 = true;
        private User _user;
        private AccountAssembler accountAssembler = new AccountAssembler();
        private bool ShowLoginForm = false;
        private bool areCredentialsValid = false;
        private bool Updatesuccess;
        private User success;
        private System.Windows.Forms.Timer animationTimer;
        private double currentOpacity;


        public RegisterForm()
        {
            InitializeComponent();

            ReEnterPasswordText.Leave += PsCheck;
            PasswordText.Leave += PsCheck;


            pbar.Value = 0;
            loadingTime.Enabled = false;

            InitializeAnimation();

        }

        public RegisterForm(User user)
        {
            InitializeComponent();
            _user = user;

            ReEnterPasswordText.Leave += PsCheck;
            PasswordText.Leave += PsCheck;

            pbar.Value = 0;
            loadingTime.Enabled = false;

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 45;
            animationTimer.Tick += AnimationTimer_Tick;

            Opacity = 0;
            animationTimer.Start();
        }

        private async void X_Click(object sender, EventArgs e)
        {
            if (_user == null)
                this.Close();

            else
            {
                DialogResult result = MessageBox.Show("Do you want to Close this window? Your data will be lost!", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    if (result == DialogResult.OK)
                    {
                        var success = await accountAssembler.DeleteUserControl(_user.UserID, globalError);
                        if (success)
                        {
                            this.Close();
                        }
                    }
                }
            }
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

            if (!IsValidePassword(PasswordText.Text))
            {
                PasswordError.Text = "Invalid password!";
                passwordLine.BackColor = Color.Red;
            }
            else
            {
                PasswordError.Text = "";
                passwordLine.BackColor = Color.Blue;
            }
        }

        private void CheckPs(object sender, EventArgs e)
        {
            if (!IsValidePassword(PasswordText.Text))
            {
                PasswordError.Text = "Invalid password!";
                passwordLine.BackColor = Color.Red;
            }
            else
            {
                PasswordError.Text = "";
                passwordLine.BackColor = Color.Blue;
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

        private void ReEnterPasswordText_Leave(object sender, EventArgs e)
        {
            if (ReEnterPasswordText.Text == "")
            {
                ReEnterPasswordText.Text = "Re-Enter Password";
                ReEnterPasswordText.UseSystemPasswordChar = false;
                ReEnterPasswordText.ForeColor = Color.Gray;
            }
        }

        private void ReEnterPasswordText_Enter(object sender, EventArgs e)
        {
            if (ReEnterPasswordText.Text.Equals("Re-Enter Password"))
            {
                ReEnterPasswordText.Text = string.Empty;
                ReEnterPasswordText.UseSystemPasswordChar = true;
                ReEnterPasswordText.ForeColor = Color.Blue;
            }
        }

        private void Firstname_Leave(object sender, EventArgs e)
        {
            if (firstnameText.Text == "")
            {
                firstnameText.Text = "Firstname";
                firstnameText.ForeColor = Color.Gray;
            }

            if (firstnameText.Text.Contains(" ") || firstnameText.Text.Any(char.IsDigit))
            {
                FirstnameError.Text = "Invalid input!";
                firstnameLine.BackColor = Color.Red;
            }
            else
            {
                FirstnameError.Text = "";
                firstnameLine.BackColor = Color.Blue;
            }
        }

        private void Firstname_Enter(object sender, EventArgs e)
        {
            if (firstnameText.Text.Equals("Firstname"))
            {
                firstnameText.Text = string.Empty;
                firstnameText.ForeColor = Color.Blue;
            }
        }

        private void Lastname_Leave(object sender, EventArgs e)
        {
            if (lastnameText.Text == "")
            {
                lastnameText.Text = "Lastname";
                lastnameText.ForeColor = Color.Gray;
            }

            if (lastnameText.Text.Contains(" ") || lastnameText.Text.Any(char.IsDigit))
            {
                LastnameError.Text = "Invalid input!";
                lastnameLine.BackColor = Color.Red;
            }
            else
            {
                LastnameError.Text = "";
                lastnameLine.BackColor = Color.Blue;
            }
        }

        private void Lastname_Enter(object sender, EventArgs e)
        {
            if (lastnameText.Text.Equals("Lastname"))
            {
                lastnameText.Text = string.Empty;
                lastnameText.ForeColor = Color.Blue;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (EmailText.Text == "")
            {
                EmailText.Text = "Email";
                EmailText.ForeColor = Color.Gray;
            }
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (EmailText.Text.Equals("Email"))
            {
                EmailText.Text = string.Empty;
                EmailText.ForeColor = Color.Blue;
            }
        }

        private void Address_Leave(object sender, EventArgs e)
        {
            if (AddressText.Text == "")
            {
                AddressText.Text = "Address";
                AddressText.ForeColor = Color.Gray;
            }
        }

        private void Address_Enter(object sender, EventArgs e)
        {
            if (AddressText.Text.Equals("Address"))
            {
                AddressText.Text = string.Empty;
                AddressText.ForeColor = Color.Blue;
            }
        }

        private void Phone_Leave(object sender, EventArgs e)
        {
            if (PhoneText.Text == "")
            {
                PhoneText.Text = "Phone";
                PhoneText.ForeColor = Color.Gray;
            }
        }

        private void Phone_Enter(object sender, EventArgs e)
        {
            if (PhoneText.Text.Equals("Phone"))
            {
                PhoneText.Text = string.Empty;
                PhoneText.ForeColor = Color.Blue;
            }
        }


        //API CALLS


        private async void NextClick(object sender, EventArgs e)
        {

            DisableFormComponent();
            //EnableLoading();*/

            if (PasswordError.Text == "" && MismatchError.Text == ""
            && PhoneError.Text == "" && FirstnameError.Text == "" && LastnameError.Text == ""
            && UsernameText.Text != "Username" && PasswordText.Text != "Password" && ReEnterPasswordText.Text != "Re-Enter Password"
            && IsEmailValide(EmailText.Text) && PhoneText.Text != "Phone" && firstnameText.Text != "Firstname" && lastnameText.Text != "Lastname" && AddressText.Text != "Address")
            {
                if (_user != null)
                {
                    byte[] passwordSalt;
                    using (var hmac = new HMACSHA512())
                    {
                        passwordSalt = hmac.Key;
                    }

                    byte[] passwordHash;
                    using (var hmac = new HMACSHA512(passwordSalt))
                    {
                        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(PasswordText.Text));
                    }

                    _user.Username = UsernameText.Text;
                    _user.PasswordHash = passwordHash;
                    _user.PasswordSalt = passwordSalt;
                    _user.Email = EmailText.Text;
                    _user.FirstName = firstnameText.Text;
                    _user.LastName = lastnameText.Text;
                    _user.Address = AddressText.Text;
                    _user.Phone = PhoneText.Text;

                    var Updatesuccess = await accountAssembler.UpdateUserInfoControl(_user, globalError, UsernameError, EmailError);
                    if (!Updatesuccess)
                    {
                        globalError.Text = "Check your info!";
                        EnableFormComponent();
                    }
                    else
                    {
                        this.Hide();

                        MembershipForm membership = new MembershipForm(_user);
                        membership.FormClosed += (s, args) => this.Close();
                        membership.Show();
                        EnableFormComponent();
                    }
                }
                else
                {
                    RegisterDTO user = new RegisterDTO
                    {
                        Username = UsernameText.Text,
                        Password = PasswordText.Text,
                        Email = EmailText.Text,
                        FirstName = firstnameText.Text,
                        LastName = lastnameText.Text,
                        Address = AddressText.Text,
                        Phone = PhoneText.Text
                    };

                    success = await accountAssembler.RegisterControl(user, globalError, UsernameError, EmailError);
                    if (success != null)
                    {
                        this.Hide();

                        MembershipForm membership = new MembershipForm(success);
                        membership.FormClosed += (s, args) => this.Close();
                        membership.Show();
                        EnableFormComponent();
                    }
                    EnableFormComponent();
                }

            }
            else
            {
                globalError.Text = "Enter All Credentials Correctly!";
                EnableFormComponent();
            }

        }

        //Validation

        public bool IsValidLebanesePhoneNumber(string phoneNumber)
        {
            Regex lebanesePhoneNumberRegex = new Regex(@"^(03|70|71|76|78)\d{6}$");
            return lebanesePhoneNumberRegex.IsMatch(phoneNumber);
        }

        public bool ArePasswordsCompatible(string originalPassword, string reenteredPassword)
        {
            return originalPassword.Equals(reenteredPassword);
        }

        public bool IsEmailValide(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, pattern))
            {
                return false;
            }
            string[] allowedDomains = { "company.com", "business.org", "workplace.net", "gmail.com" };

            string[] parts = email.Split('@');
            if (parts.Length != 2)
            {
                return false;
            }

            string domain = parts[1];
            return allowedDomains.Contains(domain, StringComparer.OrdinalIgnoreCase);
        }

        public bool IsValidePassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            if (!password.Any(c => !char.IsLetterOrDigit(c)))
            {
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                return false;
            }

            if (password.Contains(" "))
            {
                return false;
            }

            return true;
        }

        private void Visibility_click1(object sender, EventArgs e)
        {
            if (PasswordText.Text != "Password")
            {
                if (notVisible1)
                {
                    pictureBox13.Image = Properties.Resources.view;
                    notVisible1 = false;
                    PasswordText.UseSystemPasswordChar = false;
                }
                else
                {
                    pictureBox13.Image = Properties.Resources.hide;
                    notVisible1 = true;
                    PasswordText.UseSystemPasswordChar = true;
                }
            }
        }

        private void Visibility_click2(object sender, EventArgs e)
        {
            if (ReEnterPasswordText.Text != "Re-Enter Password")
            {
                if (notVisible2)
                {
                    pictureBox14.Image = Properties.Resources.view;
                    notVisible2 = false;
                    ReEnterPasswordText.UseSystemPasswordChar = false;

                }
                else
                {
                    pictureBox14.Image = Properties.Resources.hide;
                    notVisible2 = true;
                    ReEnterPasswordText.UseSystemPasswordChar = true;
                }
            }

        }

        private void EmailChange(object sender, EventArgs e)
        {
            if (!IsEmailValide(EmailText.Text))
            {
                EmailError.Text = "Invalid email!";
                EmailLine.BackColor = Color.Red;
            }
            else
            {
                EmailError.Text = "";
                EmailLine.BackColor = Color.Blue;
            }
        }

        private void PhoneCheck(object sender, EventArgs e)
        {
            if (!IsValidLebanesePhoneNumber(PhoneText.Text))
            {
                PhoneError.Text = "Invalid number!";
                PhoneLine.BackColor = Color.Red;
            }
            else
            {
                PhoneError.Text = "";
                PhoneLine.BackColor = Color.Blue;
            }
        }

        private void PsCheck(object sender, EventArgs e)
        {
            if (!ArePasswordsCompatible(PasswordText.Text, ReEnterPasswordText.Text))
            {
                MismatchError.Text = "Passwords mismatch!";
                reenterLine.BackColor = Color.Red;
            }
            else
            {
                MismatchError.Text = "";
                reenterLine.BackColor = Color.Blue;
            }
        }

        public void LoginClick(object sender, EventArgs e)
        {
            DisableFormComponent();
            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
            EnableFormComponent();
            //EnableLoading();
        }

        private void onRegisterLoad(object sender, EventArgs e)
        {
            if (_user != null)
            {
                UsernameText.Text = _user.Username;
                firstnameText.Text = _user.FirstName;
                lastnameText.Text = _user.LastName;
                EmailText.Text = _user.Email;
                AddressText.Text = _user.Address;
                PhoneText.Text = _user.Phone;

                UsernameText.ForeColor = Color.Blue;
                firstnameText.ForeColor = Color.Blue;
                lastnameText.ForeColor = Color.Blue;
                EmailText.ForeColor = Color.Blue;
                AddressText.ForeColor = Color.Blue;
                PhoneText.ForeColor = Color.Blue;
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

                    MembershipForm membership = new MembershipForm(success);
                    membership.FormClosed += (s, args) => this.Close();
                    membership.Show();

                }
                else if (ShowLoginForm)
                {
                    this.Hide();

                    LoginForm loginForm = new LoginForm();
                    loginForm.FormClosed += (s, args) => this.Close();
                    loginForm.Show();

                }
                else if (Updatesuccess)
                {
                    this.Hide();

                    MembershipForm membership = new MembershipForm(_user);
                    membership.FormClosed += (s, args) => this.Close();
                    membership.Show();
                }
            }
        }*/

        /*private void EnableLoading()
        {
            pbar.Visible = true;
            loadingTime.Enabled = true;
        }

        private void DisableLoading()
        {
            loadingTime.Enabled = false;
            pbar.Visible = false;
            pbar.Value = 0;
        }*/

        private void DisableFormComponent()
        {
            globalError.Visible = false;
            UsernameError.Visible = false;
            PasswordError.Visible = false;
            MismatchError.Visible = false;
            EmailError.Visible = false;
            PhoneError.Visible = false;
            FirstnameError.Visible = false;
            LastnameError.Visible = false;
            linkLabel1.Enabled = false;
            NextBtn.Enabled = false;
        }

        private void EnableFormComponent()
        {
            globalError.Visible = true;
            UsernameError.Visible = true;
            PasswordError.Visible = true;
            MismatchError.Visible = true;
            EmailError.Visible = true;
            PhoneError.Visible = true;
            FirstnameError.Visible = true;
            LastnameError.Visible = true;
            linkLabel1.Enabled = true;
            NextBtn.Enabled = true;
        }

        private void InitializeAnimation()
        {
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 10;
            animationTimer.Tick += AnimationTimer_Tick;

            Opacity = 0;
            animationTimer.Start();
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
    }
}
