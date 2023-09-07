namespace Library_Windows_Application.Dashboard_Controls
{
    partial class MembershipControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            panel1 = new Panel();
            MembershipDate = new Label();
            button1 = new Button();
            label2 = new Label();
            DisplayPlansPanel = new FlowLayoutPanel();
            planAactivatedControl1 = new MembershipDisplays.PlanAactivatedControl();
            RemainingLabel = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            DisplayPlansPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(230, 247, 255);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 82);
            panel2.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(RemainingLabel);
            panel1.Controls.Add(MembershipDate);
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 38);
            panel1.TabIndex = 35;
            // 
            // MembershipDate
            // 
            MembershipDate.BackColor = Color.Orange;
            MembershipDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            MembershipDate.ForeColor = Color.Blue;
            MembershipDate.Location = new Point(0, 0);
            MembershipDate.Name = "MembershipDate";
            MembershipDate.Size = new Size(506, 38);
            MembershipDate.TabIndex = 35;
            MembershipDate.Text = "Membership valide untill 05/05/2023";
            MembershipDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(965, 0);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(47, 43);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += X_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(0, 9);
            label2.Name = "label2";
            label2.Size = new Size(1012, 23);
            label2.TabIndex = 34;
            label2.Text = "Membership Plans Page";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DisplayPlansPanel
            // 
            DisplayPlansPanel.Controls.Add(planAactivatedControl1);
            DisplayPlansPanel.Dock = DockStyle.Fill;
            DisplayPlansPanel.Location = new Point(0, 82);
            DisplayPlansPanel.Name = "DisplayPlansPanel";
            DisplayPlansPanel.Size = new Size(1012, 543);
            DisplayPlansPanel.TabIndex = 22;
            // 
            // planAactivatedControl1
            // 
            planAactivatedControl1.Location = new Point(3, 3);
            planAactivatedControl1.Name = "planAactivatedControl1";
            planAactivatedControl1.Size = new Size(1012, 540);
            planAactivatedControl1.TabIndex = 0;
            // 
            // RemainingLabel
            // 
            RemainingLabel.BackColor = Color.Blue;
            RemainingLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            RemainingLabel.ForeColor = Color.Aqua;
            RemainingLabel.Location = new Point(503, 0);
            RemainingLabel.Name = "RemainingLabel";
            RemainingLabel.Size = new Size(509, 38);
            RemainingLabel.TabIndex = 36;
            RemainingLabel.Text = "Remaining borrows : 1 borrow";
            RemainingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MembershipControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(DisplayPlansPanel);
            Controls.Add(panel2);
            Name = "MembershipControl";
            Size = new Size(1012, 625);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            DisplayPlansPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button1;
        private Label label2;
        private FlowLayoutPanel DisplayPlansPanel;
        private Panel panel1;
        private MembershipDisplays.PlanAactivatedControl planAactivatedControl1;
        private Label MembershipDate;
        private Label RemainingLabel;
    }
}
