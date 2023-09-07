namespace Library_Windows_Application.PaymentControls
{
    partial class DetailsDisplayControl
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
            label22 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PickUpDate = new Label();
            ReturnDate = new Label();
            CurrentDate = new Label();
            DaysLate = new Label();
            RemoveBtn = new Button();
            ShowSeperator = new PictureBox();
            ShowSeperator2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ShowSeperator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShowSeperator2).BeginInit();
            SuspendLayout();
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(18, 18);
            label22.Name = "label22";
            label22.Size = new Size(114, 21);
            label22.TabIndex = 44;
            label22.Text = "Picked Up in :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 50);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 45;
            label1.Text = "Return before :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 82);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 46;
            label2.Text = "Current Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 114);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 47;
            label3.Text = "Days Late :";
            // 
            // PickUpDate
            // 
            PickUpDate.AutoSize = true;
            PickUpDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PickUpDate.ForeColor = Color.Blue;
            PickUpDate.Location = new Point(152, 18);
            PickUpDate.Name = "PickUpDate";
            PickUpDate.Size = new Size(100, 21);
            PickUpDate.TabIndex = 48;
            PickUpDate.Text = "PickUpDate";
            // 
            // ReturnDate
            // 
            ReturnDate.AutoSize = true;
            ReturnDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnDate.ForeColor = Color.Blue;
            ReturnDate.Location = new Point(152, 50);
            ReturnDate.Name = "ReturnDate";
            ReturnDate.Size = new Size(97, 21);
            ReturnDate.TabIndex = 49;
            ReturnDate.Text = "ReturnDate";
            // 
            // CurrentDate
            // 
            CurrentDate.AutoSize = true;
            CurrentDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CurrentDate.ForeColor = Color.Blue;
            CurrentDate.Location = new Point(152, 82);
            CurrentDate.Name = "CurrentDate";
            CurrentDate.Size = new Size(103, 21);
            CurrentDate.TabIndex = 50;
            CurrentDate.Text = "CurrentDate";
            // 
            // DaysLate
            // 
            DaysLate.AutoSize = true;
            DaysLate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DaysLate.ForeColor = Color.Blue;
            DaysLate.Location = new Point(157, 114);
            DaysLate.Name = "DaysLate";
            DaysLate.Size = new Size(79, 21);
            DaysLate.TabIndex = 51;
            DaysLate.Text = "DaysLate";
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackColor = Color.Blue;
            RemoveBtn.FlatAppearance.BorderSize = 0;
            RemoveBtn.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            RemoveBtn.FlatStyle = FlatStyle.Flat;
            RemoveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveBtn.ForeColor = Color.White;
            RemoveBtn.Location = new Point(335, 0);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(37, 35);
            RemoveBtn.TabIndex = 52;
            RemoveBtn.Text = "X";
            RemoveBtn.UseVisualStyleBackColor = false;
            // 
            // ShowSeperator
            // 
            ShowSeperator.BackColor = Color.Blue;
            ShowSeperator.Location = new Point(217, 149);
            ShowSeperator.Name = "ShowSeperator";
            ShowSeperator.Size = new Size(150, 3);
            ShowSeperator.TabIndex = 60;
            ShowSeperator.TabStop = false;
            ShowSeperator.Visible = false;
            // 
            // ShowSeperator2
            // 
            ShowSeperator2.BackColor = Color.Blue;
            ShowSeperator2.Location = new Point(0, 10);
            ShowSeperator2.Name = "ShowSeperator2";
            ShowSeperator2.Size = new Size(150, 3);
            ShowSeperator2.TabIndex = 61;
            ShowSeperator2.TabStop = false;
            ShowSeperator2.Visible = false;
            // 
            // DetailsDisplayControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            Controls.Add(ShowSeperator2);
            Controls.Add(ShowSeperator);
            Controls.Add(RemoveBtn);
            Controls.Add(DaysLate);
            Controls.Add(CurrentDate);
            Controls.Add(ReturnDate);
            Controls.Add(PickUpDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label22);
            Margin = new Padding(0);
            Name = "DetailsDisplayControl";
            Size = new Size(370, 159);
            ((System.ComponentModel.ISupportInitialize)ShowSeperator).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShowSeperator2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label22;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label PickUpDate;
        private Label ReturnDate;
        private Label CurrentDate;
        private Label DaysLate;
        private Button RemoveBtn;
        private PictureBox ShowSeperator;
        private PictureBox ShowSeperator2;
    }
}
