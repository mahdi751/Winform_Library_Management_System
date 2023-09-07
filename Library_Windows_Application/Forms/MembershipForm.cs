using Library_Windows_Application.Assemblers;
using Library_Windows_Application.DTOs;
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

namespace Library_Windows_Application.Forms
{
    public partial class MembershipForm : Form
    {
        private User _user;
        private bool isDragging;
        private Point lastMousePosition;
        private MembershipAssembler membershipAssembler = new MembershipAssembler();
        private AccountAssembler accountAssembler = new AccountAssembler();
        private bool ShowRegisterForm = false;
        private bool areCredentialsValid = false;
        private Membership membership;
        private System.Windows.Forms.Timer animationTimer;
        private double currentOpacity;
        public MembershipForm()
        {
            InitializeComponent();

            pbar.Value = 0;
            loadingTime.Enabled = false;


            InitializeAnimation();
        }

        public MembershipForm(User user)
        {
            InitializeComponent();
            _user = user;

            pbar.Value = 0;
            loadingTime.Enabled = false;


            InitializeAnimation();
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
                    var success = await accountAssembler.DeleteUserControl(_user.UserID, globalError);
                    if (success)
                    {
                        this.Close();
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

        private void PlanAisSelected(object sender, EventArgs e)
        {
            PlanASelected.Enabled = false;
            PlanBSelected.Enabled = true;
            PlanCSelected.Enabled = true;

            PlanASelected.BackColor = Color.White;
            PlanASelected.ForeColor = Color.Blue;

            PlanBSelected.BackColor = Color.Blue;
            PlanBSelected.ForeColor = Color.White;

            PlanCSelected.BackColor = Color.Blue;
            PlanCSelected.ForeColor = Color.White;

            CompletePayment.Visible = true;

            priceDetail1.Visible = true;
            priceTag.Visible = true;
            priceTag.Text = "9.99$";
            priceDetail2.Visible = true;
        }

        private void PlanBisSelected(object sender, EventArgs e)
        {
            PlanASelected.Enabled = true;
            PlanBSelected.Enabled = false;
            PlanCSelected.Enabled = true;

            PlanBSelected.BackColor = Color.White;
            PlanBSelected.ForeColor = Color.Blue;

            PlanASelected.BackColor = Color.Blue;
            PlanASelected.ForeColor = Color.White;

            PlanCSelected.BackColor = Color.Blue;
            PlanCSelected.ForeColor = Color.White;

            CompletePayment.Visible = true;

            priceDetail1.Visible = true;
            priceTag.Visible = true;
            priceTag.Text = "18.99$";
            priceDetail2.Visible = true;
        }

        private void PlanCisSelected(object sender, EventArgs e)
        {
            PlanASelected.Enabled = true;
            PlanBSelected.Enabled = true;
            PlanCSelected.Enabled = false;

            PlanCSelected.BackColor = Color.White;
            PlanCSelected.ForeColor = Color.Blue;

            PlanBSelected.BackColor = Color.Blue;
            PlanBSelected.ForeColor = Color.White;

            PlanASelected.BackColor = Color.Blue;
            PlanASelected.ForeColor = Color.White;

            CompletePayment.Visible = true;

            priceDetail1.Visible = true;
            priceTag.Visible = true;
            priceTag.Text = "25.99$";
            priceDetail2.Visible = true;
        }

        private async void PaymentClick(object sender, EventArgs e)
        {
            DisableFormComponent();
            //EnableLoading();*/

            MembershipDTO membershipDTO = new MembershipDTO();
            if (PlanASelected.Enabled == false)
            {
                membershipDTO.MembershipName = "Plan A";
                membershipDTO.MembershipPrice = 9.99;
                membershipDTO.MaxBorrowLimit = 3;
                membershipDTO.User_UserID = _user.UserID;

            }
            else if (PlanBSelected.Enabled == false)
            {
                membershipDTO.MembershipName = "Plan B";
                membershipDTO.MembershipPrice = 18.99;
                membershipDTO.MaxBorrowLimit = 6;
                membershipDTO.User_UserID = _user.UserID;

            }
            else if (PlanCSelected.Enabled == false)
            {
                membershipDTO.MembershipName = "Plan C";
                membershipDTO.MembershipPrice = 25.99;
                membershipDTO.MaxBorrowLimit = 9;
                membershipDTO.User_UserID = _user.UserID;

            }

            membership = await membershipAssembler.MembershipSubscriptionControl(membershipDTO, globalError);

            if (membership != null)
            {
                this.Hide();

                HomeForm home = new HomeForm(membership);
                home.FormClosed += (s, args) => this.Close();
                home.Show();
                globalError.Text = "";
                EnableFormComponent();
            }
            EnableFormComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            DisableFormComponent();
            this.Hide();

            RegisterForm register = new RegisterForm(_user);
            register.FormClosed += (s, args) => this.Close();
            register.Show();
            EnableFormComponent();
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
                else if (ShowRegisterForm)
                {
                    this.Hide();

                    RegisterForm register = new RegisterForm(_user);
                    register.FormClosed += (s, args) => this.Close();
                    register.Show();

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
            globalError.Visible = false;
            CompletePayment.Enabled = false;
        }

        private void EnableFormComponent()
        {
            globalError.Visible = true;
            CompletePayment.Enabled = true;
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
