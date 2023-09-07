using Library_Windows_Application.Assemblers;
using Library_Windows_Application.DTOs;
using Library_Windows_Application.MembershipDisplays;
using Library_Windows_Application.Models;

namespace Library_Windows_Application.Dashboard_Controls
{
    public partial class MembershipControl : UserControl
    {
        private Membership _membership = new Membership();

        private MembershipAssembler membershipAssembler = new MembershipAssembler();
        private BorrowAssembler borrowedBooksAssembler = new BorrowAssembler();

        private string membershipPlan;
        private Label ErrorLabel = new Label();
        private Form homeForm;
        private bool outdated = false;

        private MembershipDTO PlanA;
        private MembershipDTO PlanB;
        private MembershipDTO PlanC;
        public MembershipControl(Membership membership, Form homeform)
        {
            InitializeComponent();
            _membership = membership;
            homeForm = homeform;

            InitializePlans();
            Reload();
        }

        private void InitializePlans()
        {
            PlanA = new MembershipDTO
            {
                MaxBorrowLimit = 3,
                MembershipName = "Plan A",
                MembershipPrice = 9.99,
                User_UserID = _membership.User_UserID
            };

            PlanB = new MembershipDTO
            {
                MaxBorrowLimit = 6,
                MembershipName = "Plan B",
                MembershipPrice = 18.99,
                User_UserID = _membership.User_UserID
            };

            PlanC = new MembershipDTO
            {
                MaxBorrowLimit = 9,
                MembershipName = "Plan C",
                MembershipPrice = 25.99,
                User_UserID = _membership.User_UserID
            };
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public async Task Reload()
        {
            _ = DisplayRemaingBorrow();
            DisplayMembershipDate();

            membershipPlan = _membership.MembershipName;

            DisplayPlansPanel.Controls.Clear();

            switch (membershipPlan)
            {
                case "Plan A":
                    DisplayPlanAactivated();
                    break;

                case "Plan B":
                    DisplayPlanBactivated();
                    break;

                case "Plan C":
                    DisplayPlanCactivated();
                    break;
            }

        }

        private void DisplayPlanAactivated()
        {
            PlanAactivatedControl display = new PlanAactivatedControl();
            if (DateTime.Today > _membership.EndDate)
            {
                outdated = true;
                display.ErrorDate.Visible = true;
            }

            display.RenewA.Click += async (sender, e) =>  await HandleRenewPlan(sender);
            display.UpgradeToB.Click += async (sender, e) => await HandleChangePlan(sender, PlanB);
            display.UpgradeToC.Click += async (sender, e) => await HandleChangePlan(sender, PlanC);
            
            DisplayPlansPanel.Controls.Add(display);
        }

        private void DisplayPlanBactivated()
        {
            PlanBactivatedControl display = new PlanBactivatedControl();
            if (DateTime.Today > _membership.EndDate)
            {
                outdated = true;
                display.ErrorDate.Visible = true;
            }

            display.RenewB.Click += async (sender, e) => await HandleRenewPlan(sender);
            display.UpgradeToA.Click += async (sender, e) => await HandleChangePlan(sender, PlanA);
            display.UpgradeToC.Click += async (sender, e) => await HandleChangePlan(sender, PlanC);

            DisplayPlansPanel.Controls.Add(display);
        }

        private void DisplayPlanCactivated()
        {
            PlanCactivatedControl display = new PlanCactivatedControl();
            if (DateTime.Today > _membership.EndDate)
            {
                outdated = true;
                display.ErrorDate.Visible = true;
            }

            display.RenewC.Click += async (sender, e) => await HandleRenewPlan(sender);
            display.UpgradeToA.Click += async (sender, e) => await  HandleChangePlan(sender, PlanA);
            display.UpgradeToB.Click += async (sender, e) => await HandleChangePlan(sender, PlanB);

            DisplayPlansPanel.Controls.Add(display);
        }

        private async Task HandleRenewPlan(object sender)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to renew \" " + _membership.MembershipName + " \" ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            bool canRenew = true;
            if (result == DialogResult.OK)
            {
                if (outdated == false)
                {
                    if (await getMembershipRemainigBorrows() > 0)
                    {
                        MessageBox.Show("You still can borrow books on this membership!\nWhen your borrow limit reach 0 you can come back.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        canRenew = false;
                    }
                    else
                        canRenew = true;
                }
                else
                    canRenew = true;

                if(canRenew)
                {
                    var success = await membershipAssembler.RenewMembershipSubscriptionControl(_membership.User_UserID, ErrorLabel);
                    if (success != null)
                    {
                        DialogResult Dresult = MessageBox.Show("Membership renewed Successfully! \nKindly Relogin to you account!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        homeForm.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.FormClosed += (s, args) => homeForm.Close();
                        loginForm.Show();
                    }
                    else
                    {
                        DisplayError();
                    }
                }
            }
        }

        private async Task HandleChangePlan(object sender, MembershipDTO newMembership)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change your plan to \" " + newMembership.MembershipName + " \" ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            bool canChangePlan = false;
            if (result == DialogResult.OK)
            {
                if (outdated == false)
                {
                    if (await getMembershipRemainigBorrows() > 0)
                    {
                        MessageBox.Show("You still can borrow books on this membership!\nWhen your borrow limit reach 0 you can come back.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        canChangePlan = false;
                    }
                    else
                    {
                        if (await UnreturnedBooks())
                        {
                            MessageBox.Show("Some books are unreturned!\nReturn them to renew your plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            canChangePlan = false;
                        }
                        else
                            canChangePlan = true;
                    }
                }
                else
                {
                    if (await UnreturnedBooks())
                    {
                        MessageBox.Show("Some books are unreturned!\nReturn them to renew your plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        canChangePlan = false;
                    }
                    else
                        canChangePlan = true;
                }

                if(canChangePlan )
                {
                    var success = await membershipAssembler.MembershipSubscriptionControl(newMembership, ErrorLabel);
                    if (success != null)
                    {
                        DialogResult Dresult = MessageBox.Show("Membership applyed Successfully! \nKindly Relogin to you account!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        homeForm.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.FormClosed += (s, args) => homeForm.Close();
                        loginForm.Show();
                    }
                    else
                    {
                        DisplayError();
                    }
                }
            }
        }

        private void DisplayError()
        {
            Label errorLabel = new Label();
            errorLabel.Text = ErrorLabel.Text;
            errorLabel.ForeColor = Color.Blue;
            errorLabel.AutoSize = false;
            errorLabel.Width = label2.Width;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.Font = new Font(errorLabel.Font.FontFamily, 10, FontStyle.Bold);

            DisplayPlansPanel.AutoScroll = false;
            DisplayPlansPanel.Controls.Add(errorLabel);
        }

        private void DisplayMembershipDate()
        {
            int day = _membership.EndDate.Day;
            int month = _membership.EndDate.Month;
            int year = _membership.EndDate.Year;

            MembershipDate.Text = "Membership valide untill " + $"{day:D2}/{month:D2}/{year}";
        }

        private async Task DisplayRemaingBorrow()
        {
            RemainingLabel.Text = "Remaing borrows : " + await getMembershipRemainigBorrows() + " borrow";
        }

        private async Task<bool> UnreturnedBooks()
        {
            var unreturned = await borrowedBooksAssembler.GetUnReturnedBorrowedBooks(_membership.MembershipID);
            if (unreturned.Any())
                return true;

            return false;
        }

        private async Task<int> getMembershipRemainigBorrows()
        {
            var remaining = await membershipAssembler.GetMembershipRemainingBorrowAbility(_membership.MembershipID);

            return remaining;
        }
    }
}
