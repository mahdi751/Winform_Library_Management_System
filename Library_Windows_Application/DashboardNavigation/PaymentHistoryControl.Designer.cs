namespace Library_Windows_Application.Dashboard_Controls
{
    partial class PaymentHistoryControl
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
            ErrorLabel = new Label();
            PayAllFinesBtn = new Button();
            TotalFines = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            FinesPanel = new FlowLayoutPanel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(230, 247, 255);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 138);
            panel2.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ErrorLabel);
            panel1.Controls.Add(PayAllFinesBtn);
            panel1.Controls.Add(TotalFines);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 95);
            panel1.TabIndex = 39;
            // 
            // ErrorLabel
            // 
            ErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorLabel.ForeColor = Color.Blue;
            ErrorLabel.Location = new Point(0, 75);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(1009, 20);
            ErrorLabel.TabIndex = 42;
            ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            ErrorLabel.Visible = false;
            // 
            // PayAllFinesBtn
            // 
            PayAllFinesBtn.BackColor = Color.Orange;
            PayAllFinesBtn.Cursor = Cursors.Hand;
            PayAllFinesBtn.FlatAppearance.BorderColor = Color.OrangeRed;
            PayAllFinesBtn.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            PayAllFinesBtn.FlatStyle = FlatStyle.Flat;
            PayAllFinesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PayAllFinesBtn.ForeColor = Color.Blue;
            PayAllFinesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PayAllFinesBtn.Location = new Point(442, 38);
            PayAllFinesBtn.Name = "PayAllFinesBtn";
            PayAllFinesBtn.Size = new Size(128, 35);
            PayAllFinesBtn.TabIndex = 41;
            PayAllFinesBtn.Text = "Pay all fines";
            PayAllFinesBtn.UseVisualStyleBackColor = false;
            PayAllFinesBtn.Click += PayAllFines;
            // 
            // TotalFines
            // 
            TotalFines.BackColor = Color.PaleTurquoise;
            TotalFines.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TotalFines.ForeColor = Color.Blue;
            TotalFines.Location = new Point(862, 0);
            TotalFines.Name = "TotalFines";
            TotalFines.Size = new Size(150, 34);
            TotalFines.TabIndex = 39;
            TotalFines.Text = "To Pay : 0 $";
            TotalFines.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1009, 34);
            label1.TabIndex = 40;
            label1.Text = "Each day late will cost you 1$ !";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.refresh_page_option;
            pictureBox5.Location = new Point(13, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(26, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 38;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(965, 1);
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
            label2.Text = "Fines Page";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FinesPanel
            // 
            FinesPanel.AutoScroll = true;
            FinesPanel.BackColor = Color.White;
            FinesPanel.Dock = DockStyle.Fill;
            FinesPanel.Location = new Point(0, 138);
            FinesPanel.Name = "FinesPanel";
            FinesPanel.Size = new Size(1012, 487);
            FinesPanel.TabIndex = 24;
            // 
            // PaymentHistoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(FinesPanel);
            Controls.Add(panel2);
            Name = "PaymentHistoryControl";
            Size = new Size(1012, 625);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private Label TotalFines;
        private Panel panel1;
        private Button PayAllFinesBtn;
        private Label label1;
        private Label ErrorLabel;
        private FlowLayoutPanel FinesPanel;
    }
}
